using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "arach".Substring(0,2) + "nophobia".Substring(3);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
