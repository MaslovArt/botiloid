using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using botiloid.Subsidiary;
using System.Collections;
using System.IO;

namespace botiloid
{
    public partial class Settings : Form
    {
        GlobalVarialbles gv;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            gv = GlobalVarialbles.Constructor();

            initTextBoxes(gbServСontrol1, gv.serverCmds);
            initTextBoxes(gbServСontrol2, gv.serverCmds);
            initTextBoxes(gbGameСontrol1, gv.botKeys);

            udTimes.Value = Convert.ToInt32(gv.learning["times"]);
            labelPath.Text = gv.learning["path"];
            template.Text = gv.learning["template"];
            
        }
        private void initTextBoxes(GroupBox gb, IDictionary values)
        {
            foreach (var tbServ in gb.Controls)
            {
                var textbox = tbServ as TextBox;
                if (textbox != null)
                    textbox.Text = values[(string)textbox.Tag].ToString();
            }
        }

        private void Settings_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tabControl.TabPages[0] == tabControl.SelectedTab)
                if (!(e.KeyChar >= 48 && e.KeyChar <= 57))
                    e.Handled = true;
        }

        private void tbGame_KeyDown(object sender, KeyEventArgs e)
        {
            var textbox = sender as TextBox;
            if (textbox.Text.Length > 0)
            {
                textbox.Text = String.Empty;
                gv.botKeys[(string)textbox.Tag] = e.KeyCode;
            }
        }

        private void tbServ_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            if(textbox.Text.Length > 0)
                gv.serverCmds[(string)textbox.Tag] = Convert.ToInt32(textbox.Text);
        }

        #region Learning

        private void labelPath_click(object sender, EventArgs e)
        {
            var forlderBrowserDialog = new FolderBrowserDialog();

            DialogResult result = forlderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                labelPath.Text = forlderBrowserDialog.SelectedPath;
            }
        }
        private void labelPath_TextChanged(object sender, EventArgs e)
        {
            gv.learning["path"] = labelPath.Text;
        }
        private void template_TextChanged(object sender, EventArgs e)
        {
            gv.learning["template"] = template.Text;
        }
        private void udTimes_ValueChanged(object sender, EventArgs e)
        {
            gv.learning["times"] = udTimes.Value.ToString();
        }

        #endregion
    }
}
