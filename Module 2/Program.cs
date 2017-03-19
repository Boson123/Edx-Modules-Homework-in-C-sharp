using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i = 2;
            do
            {
                if (i % 2 == 0) // using modulo to get i = 0
                {
                    Console.WriteLine("XOXOXOXO");
                }
                else if (i % 2 == 1) // using modulo to get i = 1
                {
                    Console.WriteLine("OXOXOXOX");
                }
                i++;
            } while (i < 10);

            Console.ReadKey();

        }
    }
}
