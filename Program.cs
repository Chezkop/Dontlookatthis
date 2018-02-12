using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstString;
            string secondString;
            double firstNumber;
            double secondNumber;
            double total;

            Console.WriteLine("Calculator");

            Console.Write("First number: ");

            firstString = Console.ReadLine();

            firstNumber = Convert.ToDouble(firstString);

           Console.WriteLine();
            

             Console.Write("Second Number: ");
            secondString = Console.ReadLine();
            secondNumber = Convert.ToDouble(secondString);
           total = firstNumber + secondNumber;
           Console.WriteLine(firstNumber + "+" + secondNumber + "=" + total);
            Console.ReadKey();
        }
    }
}
