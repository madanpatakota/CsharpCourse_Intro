
/*
 * * What do you know about operators 
 * In C#, operators are symbols that perform operations on one or more operands. They are used to manipulate values, perform calculations, and control the flow of program execution. Below are operators
 * Arithmetic Operators
 * Comparison Operators
 * Logical Operators
 * Nullable types
 *  
 * Operand : In programming, an operand is a term used to describe the objects that are manipulated by operators. In other words, operands are the values or variables on which operators act.
 *  Ex : 3 + 5 and + is a operator

 */
using System;

class Operators
{
    static void Main()
    {
        /* Arithmetic Operators */
        int sum = 5 + 3;  //8

        int difference = 10 - 4; // difference is 6

        int product = 3 * 4; // product is 12

        double result = 10.0 / 3.0; // result is 3.3333...



        //int i = 10; //default

        //i = 20;

        //Console.WriteLine(i); //20

        /*Comparison Operators*/
        bool isCurrect = true;// default 
        //bool y = false;
        isCurrect =  (4 == 5); //false

        bool isEqual = (5 == 5); // isEqual is true

        bool isNotEqual = (5 != 3); // isNotEqual is true

        bool isGreater = (8 > 5); // isGreater is true

        bool isLess = (3 < 7); // isLess is true

        bool isGreaterOrEqual = (8 >= 8); // isGreaterOrEqual is true

        bool isLessOrEqual = (3 <= 7); // isLessOrEqual is true



        /*Logical Operators

        // &&  
        // T && T -- T   all the cases it will be false other than T && T
           T && F -- F
           F && F -- F
           F && T -- F

        ||
        // T || T -- T   all the cases it will be false other than T && T
           T || F -- T
           F || F -- F
           F || T -- T

        // !True  -- false
        // !false -- true



          */


        bool isResult1 = (4 == 4) && (5 == 5);
        Console.WriteLine($"Result 1 is {isResult1}");

        bool isResult2 = (4 != 4) && (5 == 5);
        Console.WriteLine($"Result 2 is && {isResult2}");



        bool isResult3 = (4 == 4) || (5 == 5);
        Console.WriteLine($"Result 3 is {isResult3}");

        bool isResult4 = (4 != 4) || (5 == 5);
        Console.WriteLine($"Result 4 is || {isResult4}");


        bool isResult5 = !(4 == 4); // !(true) = false
        Console.WriteLine($"Result 5 is || {isResult5}"); //false

        bool isResult6 = !(4 != 4); //!(false) = true
        Console.WriteLine($"Result 6 is || {isResult6}");



        /*note :
         *    = //assigemnet
         *    string str = "hello world";
         *    
         *           str == "Hello"  //false
         */



        Console.ReadLine();

    }

}

