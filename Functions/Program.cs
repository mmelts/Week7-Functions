using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimest arvu:");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teist arvu:");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Vali tehe (Sisesta '+', '-', '*' või '/')");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '*':
                    MultiplyTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '-':
                    SubtractTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }

        private static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }

        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }

        public static void SubtractTwoNumbers(double x, double y)
        {
            double result = x - y;
            Console.WriteLine(result);
        }

        public static void MultiplyTwoNumbers(double x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);
        }

        //lahutamine

        //korrutamine
    }
}
