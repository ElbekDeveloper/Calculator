using System;

namespace Calculator
{
   class Program
   {
        static void Main()
        {
            Console.WriteLine("Enter values.");
            Console.Write("First number: ");
            string firstUserValue = Console.ReadLine();
            Console.Write("Operation [+, -, *, /, %]: ");
            string operation = Console.ReadLine();
            Console.Write("Second number: ");
            string secondUserValue = Console.ReadLine();
            
            Console.WriteLine("Converting values in progress...");
            decimal firstNumber = Convert.ToDecimal(firstUserValue);
            decimal secondNumber = Convert.ToDecimal(secondUserValue);

            Console.WriteLine("Calculating results...");

            string template = $"{firstNumber} {operation} {secondNumber} =";
            decimal result = operation switch
            {
                "+" => firstNumber + secondNumber,
                "-" => firstNumber - secondNumber,
                "*" => firstNumber * secondNumber,
                "/" => firstNumber / secondNumber,
                "%" => firstNumber % secondNumber,
                _ => 0
            };

            Console.WriteLine($"{template} {result}");
        }
   } 
}

