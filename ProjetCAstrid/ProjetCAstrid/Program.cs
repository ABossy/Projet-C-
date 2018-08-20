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
            Console.WriteLine("Bonjour");
            //  <-- Afficher le nom du user! -->
            Console.WriteLine("UserName: {0} {1}", " Bienvenue", Environment.UserName);

            // <-- Afficher la Date -->
            DateTime localDate = DateTime.Now;
            var country = "fr-FR";
            Console.WriteLine("{0}: {1}", country, localDate.ToString());

            // <-- Afficher un message en focntion du jour et de l'heure -->
            if (localDate.DayOfWeek == DayOfWeek.Sunday || localDate.DayOfWeek == DayOfWeek.Saturday && localDate.Hour < 9 && localDate.Hour > 18)
            {
                Console.WriteLine("Bon Week-end : {0}", Environment.UserName);

            }
            else
                if (localDate.Hour < 13)
                {

                    Console.WriteLine("Bonjour : {0}", Environment.UserName);
                }
                else if ( localDate.Hour > 13 && localDate.Hour < 18)

                    Console.WriteLine("Bonne Après - Midi : {0}", Environment.UserName);
                else
                {
                    Console.WriteLine("Bonsoir !");

                }  
            {

                    Console.WriteLine("On est: {0}", localDate.DayOfWeek);
            }

            // <-- Affiche le contenu de ma properties GetMessage définit dans ma class Message-->
            Message astrid = new Message();
            Console.WriteLine(astrid.GetMessage);
        }
    }

   
}