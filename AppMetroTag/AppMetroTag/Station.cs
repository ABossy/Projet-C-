using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace AppMetroTag
{
    class Station
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lon")]
        public double Longitude { get; set; }

        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lines")]
        public string[] Lignes { get; set; }


        public Station[] Request()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            // Create a request for the URL. 		
            WebRequest request = WebRequest.Create("https://data.metromobilite.fr/api/linesNear/json?y=45.185270&x=5.727231&dist=800&details=true");
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            Station[] stations = JsonConvert.DeserializeObject<Station[]>(responseFromServer);

            return stations;
        }


        public void DisplayStation(Station[] stations)
        {

            IEnumerable<Station> query = from station in stations
                                         orderby station.Name
                                         select station;
            Dictionary<string, List<String>> listeStationUnique = new Dictionary<string, List<String>>();
            foreach (Station station in query)
            {
                if (!listeStationUnique.ContainsKey(station.Name))
                {
                    listeStationUnique.Add(station.Name, new List<String>(station.Lignes));
                }
                else
                {
                    foreach (var line in station.Lignes)
                    {
                        if (!listeStationUnique[station.Name].Contains(line))
                        {
                            listeStationUnique[station.Name].Add(line);

                        }
                    }

                }                              
            }

            foreach (KeyValuePair<string, List<String>> station in listeStationUnique)
            {
                Console.WriteLine(station.Key);
                foreach (string item in station.Value)
                {
                Console.WriteLine(item);
                }

            }
        }

    }
}
