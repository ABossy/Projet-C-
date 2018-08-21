using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetCAstrid
{
    class Program
    {
        static void Main(string[] args)
        {
            // <-- Affiche le contenu de ma properties GetMessage définit dans ma class Message -->
            Message astrid = new Message();
            Console.WriteLine(astrid.GetMessage);
        }
    }

   
}