using System;

namespace Calculator
{
    public class Calculator
    {
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Calculator.Multiply(2,3));
        }
    }
}
