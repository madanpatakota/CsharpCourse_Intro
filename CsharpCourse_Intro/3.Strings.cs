using System;  // System namespace

/*learn more about strings*/
class Strings
{
    static void Main()
    {
        /*string is nothing but collection of charcetrs and .should be defined in double quotes"*/

        string strName = "Csharp";
        Console.WriteLine(strName); // Csharp

        string strName1 = "\"Csharp\"";
        Console.WriteLine(strName1); // Csharp

        string numberSystem = "one , \n two , \n three";
        Console.WriteLine(numberSystem);

        string path = "D:\\Batch13\\CsharpCourse_Intro";
        Console.WriteLine(path);

        string path1 = @"D:\Batch13\CsharpCourse_Intro";
        Console.WriteLine(path1);

        //D:\Batch13\CsharpCourse_Intro


        /*** some more in string */

        string name = "John";
        int age = 30;
        string message = $"Hello , My name is {name} and age is {age}";
        Console.WriteLine(message);


        /* string is a kind of ac class which contains the set o f memebers
         * 1.property member length
         * 2.Method memeber  tolower , toupper , equals , replace , substring
         */

        string text = "{} *&%$#@!   .";
        int length = text.Length; //morethan 15 
        Console.WriteLine($"text length is {length}");


        string fName1 = "csharp";
        string output1 = fName1.ToUpper(); //CSHARP // you no need to passany parameters.
        Console.WriteLine($"fName upper case {output1}");


        string fName2 = "CshaRP";
        string output2 = fName2.ToLower(); //CSHARP // you no need to passany parameters.
        Console.WriteLine($"fName lower case {output2}");




        string password = "Hello1234";
        string confirmpassword = "Hello12345";
        //check password and confirm password equls or not.

        bool isCorrect = password.Equals(confirmpassword);  //true or false
        Console.WriteLine($"ispassword correct : {isCorrect}");

        /*Substring:
         The Substring method extracts a portion of a string, starting at a specified index and taking a specified length.
         */

        string sentence = "The quick brown fox jumps over the lazy dog.";
        string substring = sentence.Substring(1, 5);
        Console.WriteLine(substring);


        string sentence1 = "The quick brown fox jumps over the lazy dog.";
        string replaceSentence = sentence1.Replace("brown", "red");

        Console.WriteLine($"Replace sentence is : {replaceSentence}");

        //tolower , toupper , equals , replace , substring and length

        Console.ReadLine();


    }
}

