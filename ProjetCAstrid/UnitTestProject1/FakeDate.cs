using ProjetCAstrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class FakeDate : Idate
    {
        public DateTime dateToReturn { get; set; }


        public DateTime date { 
            get {
                return dateToReturn;         
            }
        }
    }

}
