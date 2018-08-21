using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCAstrid
{
    public class Message
    {
        private int matin;
        private int am; 
        private int soir;

        public string GetMessage
        {
            get
            {
                String memo = string.Empty;
                DateTime localDate = DateTime.Now;

                if (localDate.DayOfWeek == DayOfWeek.Sunday || localDate.DayOfWeek == DayOfWeek.Saturday && localDate.Hour < matin && localDate.Hour > soir)
                {
                    memo = String.Format("Bon Week-end : {0}", Environment.UserName);
                }
                else if (localDate.Hour < am)
                {
                    memo = String.Format("Bonjour : {0}", Environment.UserName);
                }
                else if (localDate.Hour > am && localDate.Hour < soir)
                {
                    memo = String.Format("Bonne Après - Midi : {0}", Environment.UserName);
                }
                else
                {
                    memo = String.Format("Bonsoir !");
                }

                memo += String.Format(" On est: {0} {1}", localDate.DayOfWeek, localDate.TimeOfDay);
                return memo;
            }


        }

       

        // <-- Constructeur -->

        public Message(int DataMatin = 8, int DataAm = 13, int DataSoir = 18){
            matin =DataMatin;
            am = DataAm;
            soir = DataSoir; 
            
        }
    }
}
