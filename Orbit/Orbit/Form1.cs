using System.Diagnostics;
using System.Runtime.CompilerServices;
using RestSharp;
using RestSharp.Authenticators;

namespace Orbit
{
    public partial class Form1 : Form
    {
        string? apiKey;
        public static Form1? instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        public void apiKeyLoad(string _apiKey)
        {
            apiKey = _apiKey;
            buttonBungieAuth.Enabled = true;
            buttonDestinyManifestLoad.Enabled = true;
            buttonLoadApiKey.Enabled = false;
            buttonCrucibleStatViewerLoad.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeAPI form2 = new InitializeAPI();
            form2.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonBungieAuth_Click(object sender, EventArgs e)
        {
            ProcessStartInfo getAuthKey = new ProcessStartInfo
            {
                FileName = "https://www.bungie.net/en/oauth/authorize?response_type=code&client_id=(INSERT VARIABLE FOR CLIENT ID LATER)&state=6i0mkLx79Hp91nzWVeHrzHG4",
                UseShellExecute = true,
            };
            Process.Start(getAuthKey);
        }
    }
}
