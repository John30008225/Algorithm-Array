using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] eg1 = new int[100000];
            Random randNum = new Random();

            for (int i = 0; i < eg1.Length; i++)
            {
                Console.Write((eg1[i] = randNum.Next(100, 999)) + " ");
                
                {
                    Console.WriteLine();
                }
            }
            Console.ReadLine();


            Stopwatch = new Stopwatch
        }
    }
}
