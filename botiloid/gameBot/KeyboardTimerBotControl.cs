using botiloid.Subsidiary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;

namespace botiloid.gameBot
{
    class KeyboardTimerBotControl : IBotControl
    {
        private class keyPresser : IComparable
        {
            public byte code;
            public int times;

            public keyPresser()
            {
                code = 0;
                times = -1;
            }
            public keyPresser(byte code, int times)
            {
                this.code = code;
                this.times = times;
            }

            public int CompareTo(object obj)
            {
                var _obj = (keyPresser)obj;
                return code - _obj.code;
            }

            public override bool Equals(object obj)
            {
                return code == ((keyPresser)obj).code;
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }

        private Size viewPort;
        private Point scCenter;
        private Rectangle fireRec, frSize1, frSize2, frSize3;

        private byte com_up, com_down, com_left, com_right, com_esLeft, com_esRight, com_fire;
        private int currentSpeed = 100;
        private int lowSpeedCor = 0;
        private int flapsPos = 1;
        private byte com_flapsNext, com_flapsPrev;
        private int cor_pitch = 80, cor_roll = 80, cor_yaw = 20;
        private bool botSpeedChange = false, botKill = false;
        private int rollStep, pitchStep;

        private List<byte> curKeys = new List<byte>(3);
        private GlobalVarialbles gv = GlobalVarialbles.Constructor();

        private System.Timers.Timer timer;
        private static List<keyPresser> currentCmds = new List<keyPresser>(3);

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        const uint KEYEVENTF_KEYUP = 0x0002;
        const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        public KeyboardTimerBotControl(Size viewPort)
        {
            this.viewPort = viewPort;
            initBotCommands();
            scCenter = new Point(viewPort.Width / 2, viewPort.Height / 2);

            frSize1 = new Rectangle(new Point(scCenter.X - 40, scCenter.Y - 20),
                                    new Size(80, 40));
            frSize2 = new Rectangle(new Point(scCenter.X - 50, scCenter.Y - 25),
                        new Size(100, 50));
            frSize3 = new Rectangle(new Point(scCenter.X - 60, scCenter.Y - 30),
                        new Size(120, 60));
            fireRec = frSize1;

            rollStep = viewPort.Width / 8;
            pitchStep = viewPort.Height / 5;
            timer = new System.Timers.Timer(60);
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
        }

        /// <summary>
        /// Управляет временем жизни команд
        /// </summary>
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            lock(currentCmds)
            {
                foreach (var cmd in currentCmds)
                    if (--cmd.times <= 0)
                        keybd_event(cmd.code, 0, KEYEVENTF_KEYUP, 0);
                currentCmds.RemoveAll(o => o.times <= 0);
            }
        }

        /// <summary>
        /// Инициализирует клавиши для управления
        /// </summary>
        private void initBotCommands()
        {
            com_down = (byte)gv.botKeys["down"];
            com_up = (byte)gv.botKeys["up"];
            com_left = (byte)gv.botKeys["left"];
            com_right = (byte)gv.botKeys["right"];
            com_esRight = (byte)gv.botKeys["esRight"];
            com_esLeft = (byte)gv.botKeys["esLeft"];
            com_flapsNext = (byte)gv.botKeys["flaps-next"];
            com_flapsPrev = (byte)gv.botKeys["flaps-prev"];
            com_fire = (byte)gv.botKeys["fire"];

            botKill = gv.botKeys["kill"] == Keys.D1;
            botSpeedChange = gv.botKeys["speed"] == Keys.D1;
        }

        /// <summary>
        /// Перемещается к точке
        /// </summary>
        /// <param name="obj">Данные приследуемого объекта</param>
        /// <returns>Возвращает выполняемые команды. Если их нет, то 'not found'</returns>
        public string moveTo(POIData poiDate)
        {
            if (poiDate == null)
                return "not found";

            if (!timer.Enabled)
                timer.Enabled = true;

            var obj = poiDate.pt;
            var command = string.Empty;

            yawMoves(obj, ref command);

            rollMoves(obj, ref command);

            pitchMoves(obj, ref command);

            if (botSpeedChange)
                speedCorrection(poiDate, obj);
            if (botKill)
                fire(obj, ref command);

            if (command == string.Empty)
                command = "streight";

            return command;
        }
        private void speedCorrection(POIData poiDate, Point obj)
        {

            if (obj.X < 10 || obj.X > viewPort.Width - 10 ||
                obj.Y < 10 || obj.Y > viewPort.Height - 10 ||
                poiDate.dist >= 90)
            {
                poiDate.speed = 100;
                lowSpeedCor = 0;
                if (currentSpeed != 100)
                    simpleKeyPress((byte)Keys.D0);
            }
            else if (poiDate.dist >= 70 && poiDate.dist < 80)
            {
                poiDate.speed = 70;
                lowSpeedCor = 1;
                if (currentSpeed != 70)
                    simpleKeyPress((byte)Keys.D7);
            }
            else if (poiDate.dist >= 50 && poiDate.dist < 60)
            {
                poiDate.speed = 50;
                lowSpeedCor = 4;
                if (currentSpeed != 50)
                    simpleKeyPress((byte)Keys.D5);
            }
            else if (poiDate.dist >= 10 && poiDate.dist < 40)
            {
                poiDate.speed = 30;
                lowSpeedCor = 6;
                if (currentSpeed != 30)
                    simpleKeyPress((byte)Keys.D3);
            }
            currentSpeed = poiDate.speed;
            //if (currentSpeed > 30)
            //    flapsToPos(1);
            //else flapsToPos(4);
        }
        private void pitchMoves(Point obj, ref string command)
        {
            if ((obj.X > 120 && obj.X < viewPort.Width - 120 &&
                obj.Y < viewPort.Height - 60))
            {
                if (obj.Y > scCenter.Y + cor_pitch)
                {
                    command += "down ";
                    putOrUpdateCmd(com_up, 6);
                }
                else if (obj.Y < scCenter.Y - cor_pitch)
                {
                    command += "up ";
                    putOrUpdateCmd(com_down, 8 + lowSpeedCor);
                }
            }
        }
        private void rollMoves(Point obj, ref string command)
        {
            if (obj.X > scCenter.X + cor_roll ||
               (obj.X > scCenter.X && obj.Y > viewPort.Height - 60))
            {
                var moveTime = 1;
                if (obj.X > viewPort.Width - 30 || obj.Y > viewPort.Height - 60)
                    moveTime = 3;
                command += "right" + moveTime + " ";
                putCmd(com_right, moveTime);
            }
            else if (obj.X < scCenter.X - cor_roll ||
                    (obj.X < scCenter.X && obj.Y > viewPort.Height - 60))
            {
                var moveTime = 1;
                if (obj.X < 10 || obj.Y > viewPort.Height - 60)
                    moveTime = 3;
                command += "left" + moveTime + " ";
                putCmd(com_left, moveTime);
            }
        }
        private void yawMoves(Point obj, ref string command)
        {
            if (Math.Abs(scCenter.Y - obj.Y) > 60 || lowSpeedCor < 5)
                return;
            if (obj.X > scCenter.X + cor_yaw && obj.X < scCenter.X + cor_roll)
            {
                command = "yaw-right ";
                putCmd(com_esRight, 3);
            }
            else if (obj.X < scCenter.X - cor_yaw && obj.X > scCenter.X - cor_roll)
            {
                command = "yaw-left ";
                putCmd(com_esLeft, 3);
            }
        }
        private void fire(Point obj, ref string command)
        {
            if (fireRec.Contains(obj))
            {
                putCmd(com_fire, 10);
                command += " fire";
            }
        }

        private void flapsToPos(int pos)
        {
            if (pos == flapsPos)
                return;

            if (pos > flapsPos)
                while (flapsPos++ < pos)
                    simpleKeyPress(com_flapsNext);
            else
                while (flapsPos-- > pos)
                    simpleKeyPress(com_flapsPrev);
        }

        /// <summary>
        /// Добавляет команду в список исполняемых команд и запускает ее если такой команды нет.
        /// </summary>
        /// <param name="code">Код клавиши</param>
        /// <param name="moveTime">Время жизни команды</param>
        private void putCmd(byte code, int moveTime)
        {
            var newCmd = new keyPresser(code, moveTime);
            if (currentCmds.Contains(newCmd))
                return;
            currentCmds.Add(newCmd);
            keybd_event(code, 0, 0, 0);
        }
        /// <summary>
        /// Добавляет команду в список исполняемых команд и запускает ее. Если команда уже есть то обновляет ее.
        /// </summary>
        /// <param name="code">Код клавиши</param>
        /// <param name="moveTime">Время жизни команды</param>
        private void putOrUpdateCmd(byte code, int moveTime)
        {
            for (int i = 0; i < currentCmds.Count; i++)
                if (currentCmds[i].code == code)
                {
                    currentCmds[i].times = moveTime;
                    return;
                }
            putCmd(code, moveTime);
        }

        private void simpleKeyPress(byte code)
        {
            keybd_event(code, 0, 0, 0);
            keybd_event(code, 0, KEYEVENTF_KEYUP, 0);
        }

        /// <summary>
        /// Завершает выполнение всех текущих команд
        /// </summary>
        public void release()
        {
            if (timer != null)
                timer.Enabled = false;

            foreach (var item in currentCmds)
                keybd_event(item.code, 0, KEYEVENTF_KEYUP, 0);
        }


        //TODO Управление закрылками
        //TODO Предотвращение раскачивания
        //TODO Позволять изменять скорость только при сближении 99-
        //TODO Исправить излишнее изменение скорости
        //TODO Добавить в класс keyPresser команду на продолжение
    }
}
