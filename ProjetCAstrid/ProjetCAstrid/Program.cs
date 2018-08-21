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
            
            Message message = new Message(8,13,18);
            Console.WriteLine(message.GetMessage);
        }
    }

   
}