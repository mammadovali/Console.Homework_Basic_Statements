using System;

namespace ConsoleApp._20210115_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tapshiriq 1: 73 ededinin tek ve ya cut oldugunu cap ede bilen alqoritma

            /*
             
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine()); 
            
            if (a % 2 == 0)
            {
                Console.WriteLine("Cutdur");
            }

            else
                Console.WriteLine("Tekdir");

            */

            // Tapshiriq 2: Ededin 4-e bolunub bolunmediyini cap eden alqoritma

            /*

            Console.Write("number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 4 == 0)
            {
                Console.WriteLine("4-e bolunur");
            }

            else
            {
                Console.WriteLine("4-e bolunmur");
            }
           
            */

            // Tapshiriq 3: 4 eded verilib (a,b,c,d). bu ededlerin ilk ikisini cemleyib, son ikisinin hasilini tapmaq.
            // sonda ise cemi hasile bolmek. ve cavabi ekrana cap etmek ( cem / hasil)

            /*
             
            Console.Write("a: ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b: ");

            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("c: ");

            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("d: ");

            int d = Convert.ToInt32(Console.ReadLine());

            
 
            int e = (a + b) / (c * d);

            Console.WriteLine($"(a + b) / (c * d) = {e}");

            */


            // Tapshiriq 4:  1-50 arasi (1 ve 50 de daxil olmaqla [1,50]) butun tek ededleri cap etmek

            /*
             

            for (int i = 1; i <= 50; i += 2)       //first method
            {
                Console.WriteLine(i);            
            }

            */

            /*
             
            int j = 1;                            // second method

            while (j <= 50)
            {
                Console.WriteLine(j);

                j += 2;
            }

            */


            // Tapshiriq 5: 1-50 arasi ancaq 5-e ya da 3-e bolunen ededleri cap etmek (misal ucun 3,5,9,12,15)

            /*

             for (int i = 1; i <= 50; i++) 
             {
                 if (i % 3 == 0 || i % 5 == 0)
                 {
                     Console.WriteLine(i);
                 }

             }

           */





        }
    }
}
