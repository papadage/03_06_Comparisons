using System;

class Comparisons
{
   static void Main()
   {
      Console.WriteLine("Please provide the first number:");
      int number1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Please provide the second number:");
      int number2 = int.Parse(Console.ReadLine());

      int sum = number1 + number2;

      Console.WriteLine($"The sum of the two numbers is {sum}.");

      if (number1 == number2)
      {
         Console.WriteLine($"{number1} = {number2}");
      }

      if (number1 != number2)
      {
         Console.WriteLine($"{number1} /= {number2}");
      }

      if (number1 > number2)
      {
         Console.WriteLine($"{number1} > {number2}");
      }

      if (number1 < number2)
      {
         Console.WriteLine($"{number1} < {number2}");
      }

      if (number1 >= number2)
      {
         Console.WriteLine($"{number1} => {number2}");
      }

      if (number1 <= number2)
      {
         Console.WriteLine($"{number1} <= {number2}");
      }
   }
}