
//ctrl k+d is the format of the file
//ctrl k+c is the comment
//ctrl k+u is for the uncomment

/*Data type conversations -- convert to one type to another type
 * 
 *  Process of converting the one datatype to another datatype
 *  
 *  Ex : string to int or
 *       int    to string like that..
 * 
 *  Implicit datatype conversations
 *  Explicit datatype conversations
 * 
 */

using System;

class DataTypeConversations
{
    static void Main()
    {
        //Implicit datatype conversations

        string str  = "12345"; // Possibility i can convert this string to the int value.
        int number = int.Parse(str); //12345
        Console.WriteLine($"number is {number}");


        int number1 = 1234;
        string str1 = number1.ToString();//string
        Console.WriteLine($"number is {str1}");


        double doubleNumber1 = 3.898988877735;
        double number3 = double.Parse(doubleNumber1.ToString());  //4
        Console.WriteLine($"number3 is {number3}"); //4

        //work : Is it possible for convert 3.898776 to the 4 by using int datatype..
        //Analysis


        //Explict conversation. we are going to give the manual convert
        int smallNumber = 5;
        double smallNumber2 = (double)smallNumber;
        long smallNumber3 = (long)smallNumber;
        Console.WriteLine($"smallNumber2 is {smallNumber2}");


        //implicit conversation .. Direct you can assign the value to the dataype
        int small = 1;
        long longValue = small;
        Console.WriteLine(longValue);


        //Explicit conversation.
        double d = 3.1888;
        int x = (int)d; // 3  // UI dis


        //Explicit conversation.
        double  d1 = 3.1888;
        decimal x1 = (decimal)d1; 



        Console.ReadLine();

    }

}

