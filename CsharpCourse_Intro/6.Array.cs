
/*
 *  Coolections of the values is nothing but array
 */


using System;

/// <summary>
/// Array in C# is collection of elements of the same data type,
/// 
/// Example set of integer values is int array
///         set of string  values is string array
/// </summary>
class Arrays
{
    static void Main()
    {
        int singleValue = 1;

        int[] numbers = { 1, 2, 3, 4 };
        int secondValue = numbers[1]; //2

        decimal[] decimals = { 1, 2, 3, 4};
        double[] doubles = { 1, 2, 3, 4 };
        bool[] booleans = { true, false, false };


        double[] prices = { 10.09, 20, 30.9877, 40 };
        Console.WriteLine(prices);  // o/p ; ___________

        //you have to take the each value from the list .... for loop
        foreach(double price in prices)  //iteration
        {
            Console.WriteLine(price);
        }

        foreach (double price in prices)  //iteration
        {
            double anotherPrice = price + 10.9098;
            Console.WriteLine(price);
            Console.WriteLine(anotherPrice);
        }


        Console.ReadLine();

        //collection of ints  []
    }
}
