

using System;
using System.Diagnostics;

/// <summary>
/// 
/// Looping system.
/// Loops in C# are used to execute a block of code repeatedly as long as a specific condition is met to creteria
/// 
/// use f10 and f11 while debugging(Recommandation)
/// </summary>
class Loops
{
    static void Main()
    {

        int i = 5;
        Console.WriteLine(i); //5

        i  = i + 10;
        Console.WriteLine(i); // 15

        i = i * 10; //150
        Console.WriteLine(i); // 150


        /*for block is a kind of a looping system
          It has three parts: initialization(int i = 0); condition(i < 5); and iteration(i++).
           The loop executes while the condition is true.

        //first time 
             number1 = 0 ;
             number1 < 5
         
         */
        //    initialization   condition        iteration
        for (int number1 = 0;number1 < 5; number1 = number1 + 1)
        {
            Console.WriteLine($"Number1 is {number1}");
            Console.WriteLine("Hello world"); // repeat
        }


        int number2 = 0;
        while (number2 < 5)
        {
            number2 = number2 + 1;  // you are updating the value..
            Console.WriteLine($"Number2 is {number2}");
            Console.WriteLine("Hello world"); // repeat
        }


        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)  //iteration
        {
            Console.WriteLine($"Number is {number}");
            Console.WriteLine("Hello world"); // repeat
        }




        Console.ReadLine();






    }
}

