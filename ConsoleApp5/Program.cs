using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        public static void doWork()
        {
            double number = 0;
            double number1 = 0;
            int pow = 0;
            double result = 0;

            Console.Write("1 - Додавання;2 - Віднімання;3 - Множення;4 - Ділення;5 - Піднесення до степеню;6 - Корінь квадратний:   ");
            int choose = Convert.ToInt32(Console.ReadLine());

            if (choose == 1)
            {
                Console.Write("Enter first number: ");
                number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Enter second number: ");
                number1 = Convert.ToDouble(Console.ReadLine());

                result = number + number1;
                Console.WriteLine("The answer is: " + result);
            }
            else if (choose == 2)
            {
                Console.Write("Enter first number: ");
                number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Enter second number: ");
                number1 = Convert.ToDouble(Console.ReadLine());

                result = number - number1;
                Console.WriteLine("The answer is: " + result);
            }
            else if (choose == 3)
            {
                Console.Write("Enter first number: ");
                number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Enter second number: ");
                number1 = Convert.ToDouble(Console.ReadLine());

                result = number * number1;
                Console.WriteLine("The answer is: " + result);
            }
            else if (choose == 4)
            {
                Console.Write("Enter first number: ");
                number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Enter second number: ");
                number1 = Convert.ToDouble(Console.ReadLine());

                if (number1 <= 0)
                {
                    checkError();
                }
                else
                {
                    result = number / number1;
                    Console.WriteLine("The answer is: " + result);
                }
            }
            else if (choose == 5)
            {
                Console.Write("Enter number: ");
                number = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Enter Pow: ");
                pow = Convert.ToInt32(Console.ReadLine());

                if (pow < 0)
                {
                    checkError();
                }
                else if (number < 0)
                {
                    checkError();
                }
                else
                {
                    result = Math.Pow(number, pow);
                    Console.WriteLine("The answer is: " + result);
                }

            }
            else if (choose == 6)
            {

                Console.Write("Enter number: ");
                number = Convert.ToDouble(Console.ReadLine());



                if (number < 0)
                {
                    checkError();
                }
                else
                {
                    result = Math.Pow(number, 2);
                    Console.WriteLine("The answer is: " + result);
                }


            }
            else
            {
                checkError();
            }

        }

        public static void checkError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error!!!!!");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {

            int chooseF = 0;
            while (true)
            {

                Console.Write("Do you want to enter?(1 - Y;2 - N): ");
                chooseF = Convert.ToInt32(Console.ReadLine());

                if (chooseF == 1)
                {
                    doWork();
                }
                else if (chooseF == 2)
                {
                    Environment.Exit(0);
                }
                else
                {
                    checkError();
                }
            }
        }
    }
}




