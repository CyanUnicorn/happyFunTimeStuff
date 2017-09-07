using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace makingStringsQuackV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Justin";

            Console.WriteLine(name);
            Console.WriteLine(name.quack());
        }
    }

    public static class Extensions
    {
        public static string quack(this string self)
        {
            return self + " quack";
        }
        
    }
}
