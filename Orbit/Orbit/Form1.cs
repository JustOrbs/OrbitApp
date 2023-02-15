using System.Diagnostics;
using System.Runtime.CompilerServices;
using RestSharp;
using RestSharp.Authenticators;

namespace Orbit
{
    public partial class Form1 : Form
    {
        string apiKey;
        public static Form1 instance;
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
                FileName = "https://www.bungie.net/en/oauth/authorize?response_type=code&client_id=40755&state=6i0mkLx79Hp91nzWVeHrzHG4",
                UseShellExecute = true,
            };
            Process.Start(getAuthKey);

            //var client = new RestClient("https://www.bungie.net/en/oauth/authorize?response_type=code&client_id=40755&state=6i0mkLx79Hp91nzWVeHrzHG4");
            //var request = new RestRequest();
            //request.AddHeader("X-API-Key", "15f4cf036b0b4af9bc2338b2c1ef4ffc");
            //request.AddHeader("Cookie", "Q6dA7j3mn3WPBQVV6Vru5CbQXv0q+I9ddZfGro+PognXQwjWM8PS+VE_=v1T9hRgw__r8l; __cflb=04dToX7HjFoF4QAzoaHehFaMj5fkjPQzpCaS7TUHC7; bungleanon=sv=BAAAAAC2QgAAAAAAAAu6KwEAAAAAAAAAAAAAAACQMy+tUp7aCEAAAADCYFR/ojplwdACRLFVE1iX6a48ZCkYrlZx+4lNMqLHpPCFS/mZ24NL0K9sVDdY3b52AsiMwMpGCWEYkWAJZwSt&cl=MC4xNzA3OC4xOTY0Mjg5MQ==; bungled=5591453895922266160; bungledid=B1KLq7vryaxDj1Mgm80E2YKCDC+tUp7aCAAA; bungles=WebView=False&UserFlowMode=SignIn&UserICT=None&UserSCT=None&UserForce=False&UserIDN=");
            //var response = client.Execute(request);
            //Console.WriteLine(response.Content);
        }
    }
}