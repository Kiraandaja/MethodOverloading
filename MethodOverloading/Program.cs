using System;

namespace MethodOverloading
{
    class Program
    {
        public static int Add(int number1, int number2)
        {
            return number1 + number2;

        }
        public static double Add(double number1, double number2)
        {
            return number1 + number2;

        }
        public static string Add(int number1, int number2, bool isTrue)
        {
            var dollarAmount = 0;
            string response = "";
            if (isTrue)
            {
                dollarAmount = number1 + number2;

                if (dollarAmount == 1)

                {
                    response = $"{dollarAmount} dollar.";
                }


                else
                {
                    response = $"{dollarAmount} dollars.";
                }

            }
            return response;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


