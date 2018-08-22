using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetCAstrid
{
    // <-- Class dans le projet qui extend l'interface et qui va recuperer les infos de DateTime-->
    class DateProjet : Idate
    {
        public DateTime date
        {
            get { return DateTime.Now; }
        }
        
    }
}
