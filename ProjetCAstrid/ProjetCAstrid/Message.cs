using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCAstrid
{
    public class Message
    {
        public string GetMessage
        {
            get 
            {
                String memo = string.Empty;
                DateTime localDate = DateTime.Now;
                
                if (localDate.DayOfWeek == DayOfWeek.Sunday || localDate.DayOfWeek == DayOfWeek.Saturday && localDate.Hour < 9 && localDate.Hour > 18)
                {
                    memo = String.Format("Bon Week-end : {0}", Environment.UserName);
                }
                else if (localDate.Hour < 13)
                {
                    memo = String.Format("Bonjour : {0}", Environment.UserName);
                }
                else if (localDate.Hour > 13 && localDate.Hour < 18)
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
    }
}
