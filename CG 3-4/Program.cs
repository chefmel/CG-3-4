using System;

namespace CG_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 numbers");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());


            Console.WriteLine("Please choose +, -, X or /");
            string op = Console.ReadLine();
            if (op == "+")
            {
                Console.WriteLine(x + y); 
            }
            else if (op == "-")
            {
                Console.WriteLine(x - y);
            }
            else if (op== "x")
            {
                Console.WriteLine(x * y);
            }
            else if (op == "/")
            {
                Console.WriteLine(x / y);
            }
            else { Console.WriteLine("you did not follow directions"); }
            Console.ReadLine();



        }
    }
}
