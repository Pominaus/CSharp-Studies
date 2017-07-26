using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleIO.JsonRead
{
    public class ReadJSON
    {
        // Want to handle the reading of data from the file players.json
        public static string FileName { get; set; } = "players.json";
        public static string FilePath { get; set; } = Directory.GetCurrentDirectory();
        private static string _filePath => Path.Combine(FilePath, FileName);
        private static FileInfo _fileInstance => new FileInfo(_filePath);

        public static List<string> GetPLayerNames()
        {
            FileInfo file = _fileInstance;
            JsonSerializer deserialise = new JsonSerializer();
            List<Player> playerList;
            List<string> outputList = new List<string>();

            if (file.Exists)
            {
                using (StreamReader reader = new StreamReader(file.Name))
                using (JsonTextReader jsonReader = new JsonTextReader(reader))
                    
                {
                    playerList = deserialise.Deserialize<List<Player>>(jsonReader);
                }
                foreach (Player player in playerList)
                {
                    outputList.Add(player.SecondName);
                }
                return outputList;
            }else
            {
                throw new Exception("Not a Valid file path: " + file.Name);
            }

        }
    }


    class Player
    {
            [JsonProperty(PropertyName = "first_name")]
            public string FirstName { get; set; }
          
            [JsonProperty(PropertyName = "points_per_game")]
            public string GamePoints { get; set; }
            
            [JsonProperty(PropertyName ="second_name")]
            public string SecondName { get; set; }
        
            [JsonProperty(PropertyName = "team_name")]
            public string TeamName { get; set; }
           

    }
}
