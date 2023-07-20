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
            Console.Write("Second number: ");
            string secondUserValue = Console.ReadLine();
            
            Console.WriteLine("Converting values in progress...");
            decimal firstNumber = Convert.ToDecimal(firstUserValue);
            decimal secondNumber = Convert.ToDecimal(secondUserValue);

            Console.WriteLine("Calculating results...");
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
            
            string userAgeValue = Console.ReadLine();
            int userAge = Convert.ToInt32(userAgeValue);

            string message = (userAge >= 18 && userAge < 28) 
                                ? "You are eligible to military service." 
                                : "You are not eligible to military service.";

            Console.WriteLine(message);
        }
   } 
}

