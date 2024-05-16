
/*
 * multi line commnets
 */
//Console.log

/// <summary>
///  Covers how to debug the code . 
///  Use Ctrl+f5 for run the propram without debug
///  
///  Use f5(continue) for run the program with debug mode
///  Use F10 for next statement(nothing but line)
///  Use F11 for jump into the method
///  </summary>

using System;

// you can give same filename as a class name
//or you can give your own class name

// Be default when you create the project their you see the class name = file name
class Basics
{
    static void Main()
    {
        /*implemetnation*/
        Console.WriteLine("Hello world");  //you can print the value.

        Console.WriteLine("Basics from Main Method(Member of the Program Class)");


        string value = Console.ReadLine();
        Console.WriteLine("Your First value is " + value);

        string value1 = Console.ReadLine();
        Console.WriteLine("Your Second value is  " + value1);


        DisplayForm();

        Console.WriteLine("****************************************End***************************");

        Console.ReadLine();  // here i did't give any value...


    }

    static void DisplayForm()
    {
        Console.WriteLine("Welcome to the Csharp course.please fill the form");
        RegistrationForm();

    }

/// <summary>
    ///  Registration form here and you should give firstname , last name , location and Job details
    ///  as a input parameters
    /// </summary>
    static void RegistrationForm()
    {
        Console.WriteLine("Details of the User.....................");
        string firstName = Console.ReadLine();
        Console.WriteLine("Your First value is " + firstName);

        string lastName = Console.ReadLine();
        Console.WriteLine("Your Second value is  " + lastName);


        string location = Console.ReadLine();
        Console.WriteLine("Your Location  is " + location);

        string Job = Console.ReadLine();
        Console.WriteLine("Your Job is  " + Job);

        Console.WriteLine("Thanks for filling the details.....................");
    }

}

