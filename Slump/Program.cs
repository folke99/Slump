using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slump
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /*
            Random randomNum = new Random();
            int[] list = new int[10];
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {                
                list[i] = randomNum.Next(21);
                sum = sum + list[i];
                Console.Write(list[i] + " ");
            }
            Console.WriteLine("medel: " +  sum/list.Length);
            Console.ReadKey();
            */
            //Övning 2
            /*
            Random randomNum = new Random();
            int[] list = new int[20];
            for (int i = 0; i < 20; i++)
            {
                list[i] = randomNum.Next(15, 31);               
            }
            Array.Sort(list);

            for (int j = 0; j < 20; j++)
            {
                if (j == 10)
                {
                    Console.Write(" | ");
                }
                
                Console.Write(list[j] + " ");
              

            }
            double med = (list[9] + list[10])/2;
         
            Console.WriteLine("Medianen: " + med);
            Console.ReadKey();
            */
            //Övning 3  KLAR I ANNAN ÖVNING
        }
    }
}
