using System;

namespace Challenge1
{
    class Program
    {
        //adds the user's inputs
        public static double Add(int num1, int num2)
        {
            double answer = num1 + num2;
            return answer;
        }

        //subtracts the user's input
        public static double Minus(int num1, int num2)
        {
            double answer = num1 - num2;
            return answer;
        }

        //divides the user's input
        public static double Divide(int num1, int num2)
        {
            double answer = num1 / num2;
            return answer;
        }

        //multiplies the user's input
        public static double Multiply(int num1, int num2)
        {
            double answer = num1 * num2;
            return answer;
        }


        static void Main(string[] args)
        {
            bool repeat = true;
            int num1;
            string operation;
            int num2;

            Console.WriteLine("Calculator");

            while (repeat)
            {
                Console.Write(Environment.NewLine);

                Console.WriteLine("Enter your first number.");
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    continue;
                }

                Console.WriteLine("Select an operator: +, -, *, /");
                try
                {
                    operation = Convert.ToString(Console.ReadLine());

                }
                catch (Exception)
                {
                    continue;
                }

                Console.WriteLine("Enter a second number.");
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    continue;
                }

                double answer = 0;
                switch (operation)
                {
                    case "+":
                        answer = Add(num1, num2);
                        break;
                    case "-":
                        answer = Minus(num1, num2);
                        break;
                    case "*":
                        answer = Multiply(num1, num2);
                        break;
                    case "/":
                        answer = Divide(num1, num2);
                        break;
                    default:
                        continue;
                }

                Console.Write(Environment.NewLine);

                Console.Write(num1);
                Console.Write(" " + operation + " ");
                Console.Write(num2);
                Console.Write(" = ");
                Console.Write(answer);

                Console.Write(Environment.NewLine);

                Console.WriteLine("Want to use the calculator again? Y / N");
                string userInput = Console.ReadLine().ToUpper();

                if (userInput == "Y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    repeat = false;
                }
            }
        }
    }
}