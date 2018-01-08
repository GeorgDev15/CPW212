using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomethingForGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 11;
            for(int i = 1; i < j; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Yo Joe!");

            if(j == 11)
            {
                j++;
            }
            Console.WriteLine(j);

            Console.ReadKey();
        }
    }
}
