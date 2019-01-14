using System;

namespace ConsoleBasedCalculator
{
    class Program
    {
       
        static void Main(string[] args)
        {
            double FirstNum = 0;
            double SecondNum = 0;
            double Result = 0;
            string ops;

            Console.WriteLine("\t\tConsole Based Calculator\n");
            Console.WriteLine("\t\t-------------------------\n");

            Console.WriteLine("\t\tEnter First Number\n");
            FirstNum = Double.Parse("\t\t" + Console.ReadLine());

            Console.WriteLine("\t\tSelect An Operator: (+,-,*,/,%)\n");
            ops = Console.ReadLine();

            Console.WriteLine("\t\tEnter Second Number\n");
            SecondNum = Double.Parse(Console.ReadLine());


            if (ops == "+")
            {
                Result = FirstNum + SecondNum;
                Console.Write("\n\t\tAddition is = " + Result);
            }

            if (ops == "-")
            {
                Result = FirstNum - SecondNum;
                Console.Write("\n" + Result);
            }
            if (ops == "*")
            {
                Result = FirstNum * SecondNum;
                Console.Write("\n\t\tMultiplication is = " + Result);
            }
            if (ops == "/")
            {
                Result = FirstNum / SecondNum;
                Console.Write("\n\t\tDivision is = " + Result);
            }
            if (ops == "%")
            {
                Result = FirstNum % SecondNum;
                Console.Write("\n\t\tModules is = " + Result);
            }

            Console.Write("\n\n" + "\t\tPress Any Key To Exit\n\n");
            Console.ReadKey();

        }
    }
}
