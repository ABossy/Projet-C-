﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppMetroTag
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Station station = new Station();
            Station[] listStations = station.Request();
            station.DisplayStation(listStations);
           
             
        }
    }
    
}
