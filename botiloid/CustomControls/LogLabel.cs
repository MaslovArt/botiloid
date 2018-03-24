using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botiloid.CustomControls
{
    class LogLabel : Label
    {
        private Timer timer = new Timer();
        public LogLabel()
        {
            timer.Tick += Timer_Tick;
            timer.Interval = 2000;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Text = "";
            timer.Enabled = false;
            timer.Stop();
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }

            set
            {
                base.Text = value;
                timer.Enabled = true;
                timer.Start();
            }
        }
    }
}
