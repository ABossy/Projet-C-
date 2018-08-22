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
        private Idate _date;


        // <-- Constructeur -->

        public Message(int DataMatin, int DataAm, int DataSoir)
            : this(new DateProjet(), DataMatin, DataAm, DataSoir)
        {
        }



        internal Message(Idate date, int DataMatin = 8, int DataAm = 13, int DataSoir = 18)
        {
            matin = DataMatin;
            am = DataAm;
            soir = DataSoir;
            _date = date;
        }

        public string GetMessage
        {
            get
            {
                String memo = string.Empty;

                if (_date.date.DayOfWeek == DayOfWeek.Sunday || _date.date.DayOfWeek == DayOfWeek.Saturday && _date.date.Hour < matin && _date.date.Hour > soir)
                {
                    memo = String.Format("Bon Week-end : {0}", Environment.UserName);
                }
                else if (_date.date.Hour < am)
                {
                    memo = String.Format("Bonjour : {0}", Environment.UserName);
                }
                else if (_date.date.Hour > am && _date.date.Hour < soir)
                {
                    memo = String.Format("Bonne Après - Midi : {0}", Environment.UserName);
                }
                else
                {
                    memo = String.Format("Bonsoir !");
                }

                memo += String.Format(" On est: {0} {1}", _date.date.DayOfWeek, _date.date.TimeOfDay);
                return memo;
            }

        }
  
        
    }
}
