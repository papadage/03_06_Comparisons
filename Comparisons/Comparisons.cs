// Figure 3.22: Comparison.cs
// Comparing integers using if statments, equality operators,
// and relational operators.

using System;

class Comparisons
{
   static void Main()
   {
      Console.Write("Enter the first number: ");
      int number1 = int.Parse(Console.ReadLine()); // Prompt user and get input for first number and pass to integer variable number1

      Console.Write("Enter the second number: ");
      int number2 = int.Parse(Console.ReadLine()); // Prompt user and get input for first number and pass to integer variable number2

      if (number1 == number2) // Compare values according to parameter of if stament
      {
         Console.WriteLine($"{number1} = {number2}"); // Output text if the comparison is true
      }

      if (number1 != number2)
      {
         Console.WriteLine($"{number1} != {number2}");
      }

      if (number1 > number2)
      {
         Console.WriteLine($"{number1} > {number2}");
      }

      if (number1 < number2)
      {
         Console.WriteLine($"{number1} < {number2}");

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


//using System;

//class Comparisons
//{
//   static void Main()
//   {
//      Console.Write("Enter the first number: ");
//      int number1 = int.Parse(Console.ReadLine());

//      Console.Write("Enter the second number: ");
//      int number2 = int.Parse(Console.ReadLine());

//      if (number1 == number2)
//      {
//         Console.WriteLine($"{number1} equals {number2}.");
//      }

//      if (number1 != number2)
//      {
//         Console.WriteLine($"{number1} does not equal {number2}.");
//      }

//      if (number1 > number2)
//      {
//         Console.WriteLine($"{number1} is greater than {number2}.");
//      }

//      if (number1 < number2)
//      {
//         Console.WriteLine($"{number1} is less than {number2}.");
//      }

//      if (number1 >= number2)
//      {
//         Console.WriteLine($"{number1} is greater than or equal to {number2}.");
//      }

//      if (number1 <= number2)
//      {
//         Console.WriteLine($"{number1} is less than or equal to {number2}.");
//      }
//   }
//}


//using System;

//class Comparisons
//{
//   static void Main()
//   {
//      Console.WriteLine("Please provide the first number:");
//      int number1 = int.Parse(Console.ReadLine());

//      Console.WriteLine("Please provide the second number:");
//      int number2 = int.Parse(Console.ReadLine());

//      int sum = number1 + number2;

//      Console.WriteLine($"The sum of the two numbers is {sum}.");

//      if (number1 == number2)
//      {
//         Console.WriteLine($"{number1} = {number2}");
//      }

//      if (number1 != number2)
//      {
//         Console.WriteLine($"{number1} /= {number2}");
//      }

//      if (number1 > number2)
//      {
//         Console.WriteLine($"{number1} > {number2}");
//      }

//      if (number1 < number2)
//      {
//         Console.WriteLine($"{number1} < {number2}");
//      }

//      if (number1 >= number2)
//      {
//         Console.WriteLine($"{number1} => {number2}");
//      }

//      if (number1 <= number2)
//      {
//         Console.WriteLine($"{number1} <= {number2}");
//      }
//   }
//}