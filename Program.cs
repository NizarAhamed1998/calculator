using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClass calc = new CalculatorClass();
            string method = "";
            string format = "";
            calc.Total = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            format += calc.Total;
            do
            {
                Console.Write(format);
                method = Console.ReadLine();
                Console.Clear();
                Console.Write(format += method); 
                calc.Value = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.Write(format += calc.Value); 
                
                if (method=="+")
                {
                    calc.addition(calc);
                }
                else if (method=="-")
                {
                    calc.subtract(calc);
                }
                else if (method=="*")
                {
                    calc.multiply(calc);
                }
                else if (method=="/")
                {
                    calc.divide(calc);
                }
            } while (ConsoleKey.Enter==Console.ReadKey().Key);
            Console.Clear();
            Console.WriteLine(format);
            Console.WriteLine(calc);
        }
    }
}
