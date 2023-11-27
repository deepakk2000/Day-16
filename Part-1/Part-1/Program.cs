using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    internal class Program
    {

        public delegate int ArithmeticOperation(int num1, int num2);
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            ArithmeticOperation addDelegate = new ArithmeticOperation(Add);
            ArithmeticOperation subtractDelegate = new ArithmeticOperation(Subtract);
            ArithmeticOperation multiplyDelegate = new ArithmeticOperation(Multiply);
            ArithmeticOperation divideDelegate = new ArithmeticOperation(Divide);

            Console.Write("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            int choice = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            switch (choice)
            {
                case 1:
                    result = addDelegate(num1, num2);
                    break;
                case 2:
                    result = subtractDelegate(num1, num2);
                    break;
                case 3:
                    result = multiplyDelegate(num1, num2);
                    break;
                case 4:
                    result = divideDelegate(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid arithmetic operation.");
                    break;
            }
            Console.WriteLine($"Result: {result}");
        }
    }
}
