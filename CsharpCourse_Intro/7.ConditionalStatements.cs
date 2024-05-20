

using System;

/// <summary>
/// Conditional statements in C# allow you to control the flow of your program based on certain condition and expression(s). 
/// They enable you to execute specific code blocks if certain conditions are met. 
/// 
/// Set of statements executes based on the condition.
/// 
/// if elseif else   //less condtions 1 if 2 elseif 
/// 
/// if(true){ 
/// -------------------------------------------; //statement
/// }
///
/// 
/// switch case condtion.(read mode is good)
/// 
/// </summary>

class ConditionalStatements
{
    static void Main()
    {

        int num1 = 50;
        //    50 >30
        if (num1 > 30)
        {
            Console.WriteLine("Number is greater than 50.");
        }


       // if * else

        int num2 = 10;//In real time env you will receive from the UI
        //   10 > 30
        if (num2 > 30)
        {
            Console.WriteLine("Number is greater than 30.");
        }
        else
        {
            Console.WriteLine($"Hey!!!! Number you entered not greathan 30 . YOur number is {num2}");
        }


        int num3 = 10;

        if (num3 > 30)
        {
            Console.WriteLine("Number is greater than 30.");
        }
        else if(num3 == 100)
        {
            Console.WriteLine("Number is 100.");
        }
        else if(num3 < 30){
            Console.WriteLine("Number is less than 30");
        }
        else
        {
            Console.WriteLine($"Hey!!!! Number you entered not greathan 30 . YOur number is {num2}");
        }


       

        /*
         *   switch(<value>){
         *       case comparevalue
         *         statements;
         *       break;
         *       case comparevalue
         *         statements;
         *       break;
         *       case comparevalue
         *         statements;
         *       break;
         *       default:
         *       break;
         *   }
         * 
         * 
         */



        int num4 = 20;//you will receive from the UI
        switch(num4)
        {
            case 100: //num4 is 100
                Console.WriteLine("YOu are enter 100");
                 break;
            case 20: //num4 is 20
                Console.WriteLine("YOu are enter 20");
                break;
            case 10: //num4 is 10
                Console.WriteLine("YOu are enter 10");
                break;
            default:
                Console.WriteLine("YOu are enter different value not 100 , 20 and 10");
                break;

        }



        string role = "Admin";//you will receive from the UI
        switch (role)
        {
            case "SalesRep": //num4 is 100
                Console.WriteLine("YOu are Sales rep");
                break;
            case "Viewer": //num4 is 20
                Console.WriteLine("you are viewer");
                break;
            case "Admin": //num4 is 10
                Console.WriteLine("YOu are Admin");
                break;
            case "HR": //num4 is 10
                Console.WriteLine("YOu are HR");
                break;
            default:
                Console.WriteLine("YOu do't have any role .please contact support team for assigning the role to you..........");
                break;

        }







        Console.ReadLine();





    }
}
