using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace botiloid.server
{
    public partial class Connect : Form
    {
        private int port;
        private string userName;
        private string hostName;

        public Connect()
        {
            InitializeComponent();
        }

        public int Port
        {
            get { return port; }
            private set { port = value; }
        }
        public string UserName
        {
            get { return userName; }
            private set { userName = value; }
        }
        public string HostName
        {
            get { return hostName; }
            private set { hostName = value; }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                userName = tb_clientName.Text;
                hostName = tb_hostName.Text;
                port = Convert.ToInt32(tb_port.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения полей!");
            }
            DialogResult = DialogResult.OK;
        }
    }
}
