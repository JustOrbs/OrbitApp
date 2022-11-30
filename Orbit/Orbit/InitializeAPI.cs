using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Orbit
{
    public partial class InitializeAPI : Form
    {
        public InitializeAPI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelRegisterApiKey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo getKey = new ProcessStartInfo
            {
                FileName = "https://www.bungie.net/en/application",
                UseShellExecute = true
            };
            Process.Start(getKey);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apikey = textBoxApiKey.Text;

        }
    }
}
