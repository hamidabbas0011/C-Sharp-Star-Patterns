using System.Net.Security;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the max number of stars you want to create pattern with");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Hello, World!");
            TriPattern(number);
            Rectangle(number);
            ReverseTriangle(number);
        }

        private static void ReverseTriangle(int num)
        {
            for (int i = num; i>0 ; i--)
            {
                for (int j = 0; j<i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void TriPattern(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void Rectangle(int num)
        {
            for (int i = 0; i < num; i++)
            {
                if (i==0 || i ==(num-1))
                {
                    for (int j = 0; j < num; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine() ;
                }
                else if (i>=1 || i<=(num-2))
                {
                    for (int j = 0; j < num; j++)
                    {
                        if (j == 0 || j == (num - 1))
                        {
                            Console.Write("*");
                        }

                        else if (j >= 1 && j <= (num - 2))
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

        }
    }
}
