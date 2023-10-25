using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalsaString2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi rečenicu: ");
            string s1= Console.ReadLine();

            Console.WriteLine(s1.Replace(" ", "_"));
            Console.ReadKey();
        }
    }
}
