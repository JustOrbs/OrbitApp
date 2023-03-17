using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orbit
{
    internal class OAuthHandler
    {
        RestClient client = new RestClient("https://www.bungie.net/Platform/App/OAuth/token/");
        dynamic? jsonResponse;
        string? accessToken;
        string? refreshToken;
        userData? activeUser;
        public OAuthHandler(userData userData)
        {
            activeUser = userData;
        }
        
        public void generateTokens()
        {
            ProcessStartInfo getAuthKey = new ProcessStartInfo
            {
                FileName = "https://www.bungie.net/en/oauth/authorize?response_type=code&client_id=" + activeUser.clientId + ".&state=6i0mkLx79Hp91nzWVeHrzHG4",
                UseShellExecute = true,
            };
            Process.Start(getAuthKey);

        }
    }

}
