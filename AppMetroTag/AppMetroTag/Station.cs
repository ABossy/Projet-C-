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
        public string name { get; set; }

        [JsonProperty("lon")]
        public double longitude { get; set; }

        [JsonProperty("lat")]
        public double latitude { get; set; }

        [JsonProperty("lines")]
        public string[] lignes { get; set; }


        public Station[] request()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            // Create a request for the URL. 		
            WebRequest request = WebRequest.Create("https://data.metromobilite.fr/api/linesNear/json?y=45.185270&x=5.727231&dist=600&details=true");
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            // Cleanup the streams and the response.
            Station[] stations = JsonConvert.DeserializeObject<Station[]>(responseFromServer);

            return stations;
        }


        public void DisplayStation(Station[] stations)
        {

            IEnumerable<Station> query = from station in stations
                                         orderby station.name
                                         select station;
            Dictionary<string, List<String>> listeStationUnique = new Dictionary<string, List<String>>();
            foreach (Station station in query)
            {
                if (!listeStationUnique.ContainsKey(station.name))
                {
                    listeStationUnique.Add(station.name, new List<String>(station.lignes));
                }
                else
                {
                    foreach (var line in station.lignes)
                    {
                        if (!listeStationUnique[station.name].Contains(line))
                        {
                            listeStationUnique[station.name].Add(line);

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
