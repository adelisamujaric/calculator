using System;

namespace CalculatorTest2
{
    public class Calculator
    {
        public string WriteText(string text)
        {
            return text;
        }

        public string WriteNumber(int a)
        {
            return a.ToString();
        }

        public int operand1;
        public int operand2;
        public Calculator(int operand1, int operand2)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Calculator Calculator = new Calculator(1, 2);
            string s = Calculator.WriteText("Hello World");
            Console.WriteLine(s);
            string n = Calculator.WriteNumber(57 + 24);
            Console.WriteLine(n);

            Console.ReadLine();

        }
    }
}
