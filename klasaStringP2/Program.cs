using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst;
            Console.WriteLine("Unesi neku recenicu: ");
            tekst = Convert.ToString(Console.ReadLine());

           
     
        Console.WriteLine(tekst.Replace((" "), "_"));

        Console.ReadKey();
            
        }
    }
}
