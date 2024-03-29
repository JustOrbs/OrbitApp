﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using RestSharp;
using RestSharp.Authenticators;

namespace Orbit
{
    public partial class InitializeAPI : Form
    {
        public InitializeAPI()
        {
            InitializeComponent();
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
            string clientId = textBoxClientId.Text;
            string currentPath = AppDomain.CurrentDomain.BaseDirectory;
            var client = new RestClient("https://www.bungie.net/Platform/GroupV2/User/254/10991356/0/1/");
            var request = new RestRequest();
            request.AddHeader("x-api-key", apikey);
            var response = client.Execute(request);
            if (response.IsSuccessStatusCode)
            {
                Form1.instance.apiKeyLoad(apikey);
                KeySerializer.verifyCreateKeyFile(currentPath);
                KeySerializer.saveKeysToFile(currentPath, apikey, clientId);
                this.Close();
            }
            
        }
    }
}
