using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botiloid
{
    class IndicatorControl : PictureBox
    {
        private int status = 0;
        private string mainTitle;
        public event Action<object, int> StatusChange;
        private ToolTip tooltip;
        string[] stateTitles;
        Bitmap[] stateImsg;

        public IndicatorControl()
        {
            tooltip = new ToolTip();
            this.MouseHover += ((obj, args) => {
                if (stateTitles != null)
                    tooltip.Show(mainTitle + ": " + stateTitles[status], this, 3000);
            });
        }

        public string MainTitle
        {
            get { return mainTitle; }
            set { mainTitle = value; }
        }

        public string StateTitle
        {
            get { return stateTitles[status]; }
        }
        public int Status
        {
            get
            {
                return status;
            }
            set
            {
                if (value <= 0)
                    return;

                System.Media.SystemSounds.Beep.Play();
                status = value;
                if (StatusChange != null)
                    StatusChange(this, status);

                if (stateImsg != null)
                {
                    if (stateImsg.Length >= status)
                        this.BackgroundImage = stateImsg[status];
                }
            }
        }
        public void setStatusTitles(params string[] statuse)
        {
            stateTitles = statuse;
        }
        public void setStatusImgs(params Bitmap[] imgs)
        {
            stateImsg = imgs;
        }
    }
}
