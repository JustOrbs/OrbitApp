using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text.Json;

namespace Orbit
{
    internal class KeySerializer
    {
        
        public static void verifyCreateKeyFile(string path) //Checks to see if key.json exists and creates a new copy if it doesn't
        {
            if(!File.Exists((path + "key.json")))
            {
                var keyFile = File.Create(path + "key.json");
                keyFile.Close();
            }
         
        }

        public static void saveKeysToFile(string path, string apiKey, string clientID) //Saves the api key to a file key.json
        {
            string jsonString = JsonSerializer.Serialize(new userData(apiKey, clientID));
            File.WriteAllText( path + "key.json", jsonString);
        }

        public static userData loadKeyFromFile() //Loads the api key from key.json and throws an error if null
        {
            string jsonStringFromFile = File.ReadAllText("key.json");
            userData returnKey = JsonSerializer.Deserialize<userData>(jsonStringFromFile);
            if (returnKey != null)
            {
                return returnKey;
            }
            else
            {
                throw new Exception("You're bad lol (no data in key.json, delete the file and relaunch the program)"); //Funny error
            }
        }
    }

    internal class userData
    {
        public string apiKey { get; private set; }
        public string clientId { get; private set; }
        public userData(string apiKey, string clientId)
        {
            this.apiKey = apiKey;
            this.clientId = clientId;
        }
    }
}
