using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---The number of steps is recommended no more than 10 due to the large number of digits---");



            Console.WriteLine("\nEnter the first number for the Morse-Thue sequence: 0 or 1");

            string firstNumber =Console.ReadLine();

            Console.WriteLine("Enter the number of steps for the Morse-Thue sequence");

            int n= Int32.Parse(Console.ReadLine());

             
        //    Console.WriteLine(firstNumber[1]);

            

            for (int i=0; i<n; i++)
            {

                var k = firstNumber.Length;

                for (int j = 0; j < k; j++)
                {

                    if (firstNumber[j] == Char.Parse("0"))
                    {

                        firstNumber = firstNumber + "1";
                       

                    }
                    else if (firstNumber[j] == Char.Parse("1"))
                    {

                        firstNumber = firstNumber + "0";
                        


                    }

                }
                Console.WriteLine("\n"+firstNumber);

            }




            Console.WriteLine("\nPress \"Enter\" to exit");
            Console.ReadLine();

        }
    }
}
