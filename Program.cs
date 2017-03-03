using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int uitkomst = Rekensom.minSom(9, 2);

            Rekensom som = new Rekensom();
            int uitkomst2 = som.plusSom(9, 9);

            Console.WriteLine("uitkomst 1 = " + uitkomst);
            Console.WriteLine("uitkomst 2 = " + uitkomst2);

            Console.WriteLine("first commit");
            Console.WriteLine("and now");


            Console.WriteLine("test");

        }
    }
}
