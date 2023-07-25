using System;

namespace Calculator
{
   class Program
   {
        static void Main()
        {
            string yesorNo = "";
            do
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

                Console.WriteLine("Do you want to continue? [y/n]");
                yesorNo = Console.ReadLine();
            } while (yesorNo == "y");

            Console.WriteLine("Thank you for using our calculator.");
            Console.WriteLine("Here is the multiplication table for your reference.");
            for(int outerIteration = 2; outerIteration < 10; outerIteration++)
            {
                Console.WriteLine("********");
                for(int iteration = 1; iteration < 10; iteration++)
                {
                    Console.WriteLine($"{outerIteration} * {iteration} = {outerIteration * iteration}");
                }
            }
        }
   } 
}

