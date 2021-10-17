using System;

namespace Homework_module3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input number of Decimal value: ");
            string number1 = Console.ReadLine();
            decimal result1 = 0;
            if (decimal.TryParse(number1, out result1))
            {
                //decimal decimalVariable = Convert.ToDecimal(number1);
                Console.WriteLine($"Absolute number of Decimal value: {Math.Abs(result1)}");
            }
            else
            {
                Console.WriteLine("It is not a valid input!");
            }
                     
            Console.Write(Environment.NewLine);

            Console.Write("Please input number of Double value: ");
            string number2 = Console.ReadLine();
            double result2 = 0;
            if (double.TryParse(number2, out result2))
            {
                //double doubleVariable = Convert.ToDouble(number2);
                Console.WriteLine($"Absolute number of Double value: {Math.Abs(result2)}");
            }
            else
            {
                Console.WriteLine("It is not a valid input!");
            }
            Console.Write(Environment.NewLine);

            Console.Write("Please input number of Int16 value: ");
            string number3 = Console.ReadLine();
            short result3 = 0;
            if (short.TryParse(number3, out result3))
            {
                //short shortVariable = Convert.ToInt16(number3);
                Console.WriteLine($"Absolute number of Int16 value: {Math.Abs(result3)}");
            }
            else
            {
                Console.WriteLine("It is not a valid input!");
            }
            Console.Write(Environment.NewLine);

            Console.Write("Please input number of Int32 value: ");
            string number4 = Console.ReadLine();
            int result4 = 0;
            if (int.TryParse(number4, out result4))
            {
                //int intVariable = Convert.ToInt32(number4);
                Console.WriteLine($"Absolute number of Int32 value: {Math.Abs(result4)}");
            }
            else
            {
                Console.WriteLine("It is not a valid input!");
            }
            Console.Write(Environment.NewLine);

            Console.Write("Please input number of Int64 value: ");
            string number5 = Console.ReadLine();
            long result5 = 0;
            if (long.TryParse(number5, out result5))
            {
                //long longVariable = Convert.ToInt64(number5);
                Console.WriteLine($"Absolute number of Int64 value: {Math.Abs(result5)}");
            }
            else
            {
                Console.WriteLine("It is not a valid input!");
            }

            Console.ReadLine();
        }
    }
}
