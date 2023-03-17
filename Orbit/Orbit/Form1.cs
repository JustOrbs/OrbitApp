using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using RestSharp;
using RestSharp.Authenticators;
using System.Text.Json;

namespace Orbit
{
    public partial class Form1 : Form
    {
        string? apiKey;
        public static Form1 instance = new();
        userData? activeUser;
        string currentPath = AppDomain.CurrentDomain.BaseDirectory;
        OAuthHandler oAuthHandler;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            if (File.Exists(currentPath + "key.json"))
            {

                try
                {
                    userData userData = KeySerializer.loadKeyFromFile();
                    apiKeyLoad(userData.apiKey);
                    testApiKey(userData.apiKey);
                    oAuthHandler = new OAuthHandler(userData);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            

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
            oAuthHandler.generateTokens();
        }

        public static void testApiKey(string apiKey)
        {
            var client = new RestClient("https://www.bungie.net/Platform/GroupV2/User/254/10991356/0/1/");
            var request = new RestRequest();
            request.AddHeader("x-api-key", apiKey);
            var response = client.Execute(request);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Invalid api key");
            }
        }
    }
}
