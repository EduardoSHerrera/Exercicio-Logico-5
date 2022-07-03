using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i, num;
            for(i = 1; i <= 100; i++)
            {

                num = i % 2;
                if (num % 2 == 0)
                {
                    Console.WriteLine("numero par: " + i);
                }

            }

            Console.ReadKey();
        }
    }
}
