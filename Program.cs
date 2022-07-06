using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exerc 5");
            int i = 0;
            
            while (i < 100 )
            {
                i++;
                if (i%2 ==0)
                {
                    Console.WriteLine(i);
                }
                
            }

            Console.ReadKey();
        }
    }
}
