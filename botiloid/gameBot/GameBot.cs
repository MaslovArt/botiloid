﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace botiloid.gameBot
{
    class GameBot
    {
        public enum Mode
        {
            Default,
            Learning
        }
        public enum State
        {
            NotInitialized = 0,
            Initialization = 1,
            Ready = 2,
            Active = 3
        }

        /// <summary>
        /// Процесс контролируемой игры
        /// </summary>
        private Process gameProc;
        /// <summary>
        /// Анализ изображения
        /// </summary>
        private BotCV cv;
        /// <summary>
        /// Способ управления игрой
        /// </summary>
        private IBotControl bc;
 
        /// <summary>
        /// Запись полета
        /// </summary>
        private BotLearning bl;
        
        private State status = State.NotInitialized;
        private Mode _mode = Mode.Default;
        //private Size winResolution = null;
        /// <summary>
        /// Прерывание бота
        /// </summary>
        private CancellationTokenSource cts;

        /// <summary>
        /// Событие изменения состояния бота
        /// </summary>
        public event Action<State> onStateChange;
        /// <summary>
        /// Событие поступления данных объекта
        /// </summary>
        public event Action<POIData> onDataReport;

        /// <summary>
        /// Замер fps
        /// </summary>
        private Stopwatch sw = new Stopwatch();
        public event Action<Object> botDebug;

        public GameBot()
        {

        }

        public string WinTitle
        {
            get { return gameProc.MainWindowTitle; }
        }
        public IntPtr WinDescriptor
        {
            get { return gameProc.MainWindowHandle; }
        }
        public State Status
        {
            private set {
                status = value;
                if (onStateChange != null)
                    onStateChange(status);
            }
            get { return status; }
        }
        public Mode BMode
        {
            get { return _mode; }
            set { _mode = value; }
        }

        /// <summary>
        /// Запускает инициализацию бота
        /// </summary>
        /// <param name="winName">Паттер поиска процесса</param>
        public void initBotAsync(string winName)
        {
            if (status > State.NotInitialized)
                return;
            Task.Run(() =>
            {
                Status = State.Initialization;
                Regex rgx = new Regex(winName, RegexOptions.IgnoreCase);
                while (true)
                {
                    Thread.Sleep(5000);
                    var runningProc = getRunProcesses();
                    foreach (var item in runningProc)
                    {
                        if (rgx.IsMatch(item.MainWindowTitle))
                        {
                            gameProc = item;
                            gameProc.EnableRaisingEvents = true;
                            gameProc.Exited += GameProc_Exited;
                            NativeWin32.SetForegroundWindow(gameProc.MainWindowHandle.ToInt32());
                            Status = State.Ready;
                            return;
                        }
                    }
                }
            });
        }

        /// <summary>
        /// Запуск бота в выбранном режиме (по умолчанию Mode.Default)
        /// </summary>
        public void RunAsync()
        {
            if (status < State.Ready)
                throw new BotNotInitException("bot not init");
            if (status == State.Active)
                return;

            if (cv == null)
                cv = new BotCV(WinDescriptor, 118, 140, 140, 120, 255, 255);

            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            bool startState = false;
            switch(_mode)
            {
                case Mode.Default: startState = botWork(token); break;
                case Mode.Learning: startState = botLearning(token); break;
            }
            if (startState)
                Status = State.Active;
        }

        /// <summary>
        /// Остановка бота
        /// </summary>
        public void Stop()
        {
            if (cts != null)
                cts.Cancel();
            if (bl != null)
                bl.StopRecord();

            Status = State.Ready;
        }

        /// <summary>
        /// Обработка события закрытия приложения игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameProc_Exited(object sender, EventArgs e)
        {
            Status = State.NotInitialized;
            if (cts != null)
                cts.Cancel();
        }

        /// <summary>
        /// Робота бота в Mode.Default
        /// </summary>
        /// <param name="token">Источник признака отмены</param>
        private bool botWork(CancellationToken token)
        {
            if (bc == null)
                bc = new KeyboardTimerBotControl(cv.ViewPort);
            Task.Run(() =>
            {
                POIData defPOI = new POIData(new Point(-1, -1), -1);
                while (true)
                {
                    sw.Restart();
                    if (token.IsCancellationRequested)
                    {
                        if (bc != null)
                            bc.release();
                        break;
                    }
                    var obj = cv.detectObj();
                    var com = bc.moveTo(obj);
                    if (obj == null)
                        obj = defPOI;
                    else
                        obj.command = com;
                    sw.Stop();
                    obj.fps = 1000 / sw.ElapsedMilliseconds;
                    if (onDataReport != null)
                        onDataReport(obj);
                }
            }, token);
            return true;
        }

        /// <summary>
        /// Работа бота в Mode.Learning (запись полета)
        /// </summary>
        /// <param name="token">Источник признака отмены</param>
        private bool botLearning(CancellationToken token)
        {
            if (bl == null)
                bl = new BotLearning(cv);

            return bl.StartRecordAsync();        
        }

        /// <summary>
        /// Получает все исполняемые процессы
        /// </summary>
        /// <returns>Список процессов</returns>
        private List<Process> getRunProcesses()
        {
            Process[] processlist = Process.GetProcesses();
            var result = new List<Process>();
            foreach (Process process in processlist)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    result.Add(process);
                }
            }
            return result;
        }
    }
}
