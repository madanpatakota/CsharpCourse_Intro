using System;
using System.Runtime.Remoting.Messaging;
class Datatypes
{
    /*Datatypes in Csharp 
      Numeric Data Types: byte , short , ushort , unit , ulong ,
                           float , decimal , double , int , long

     Boolean Data Type:
        -----------------------
     bool: Represents Boolean values true or false.

     char: Represents a single  character by single quote

     string: Represents a sequence of characters by double quotes

     // i need to some time...
      void , object , dynamic
     
     */
    static void Main()
    {
        // 0 to 255(range)

        // How to find the range of the byte
        byte byteValue = 10;
        byte byteValue1 = 255;

        //ctrl k,c
        //Console.WriteLine(byte.MinValue);
        //Console.WriteLine(byte.MaxValue);

        //string interpolation $""
        //Console.WriteLine($"byte datatype minvalue is {byte.MinValue} and maxvalue is {byte.MaxValue}");

        Console.WriteLine("byte datatype minvalue is {0} and maxvalue is {1}" , byte.MinValue , byte.MaxValue);

        Console.WriteLine("short datatype minvalue is {0} and maxvalue is {1}", short.MinValue, short.MaxValue);

        Console.WriteLine("short datatype minvalue is {0} and maxvalue is {1}", short.MinValue, short.MaxValue);

        Console.WriteLine("ushort datatype MaxValue : {0} and MinValue : {1} ", ushort.MaxValue, ushort.MinValue);

        Console.WriteLine("uint datatype MaxValue : {0} and MinValue : {1}  ", uint.MaxValue, uint.MinValue);

        Console.WriteLine("ulong datatype MaxValue : {0} and MinValue : {1} ", ulong.MaxValue, ulong.MinValue);

        Console.WriteLine("$float datatype MaxValue : {0} and MinValue : {1}  ", float.MaxValue, float.MinValue); //3.402823E+38  means 3.402823*10^38(10powerof38)

        Console.WriteLine("$decimal datatype MaxValue : {0} and MinValue : {1}  ", decimal.MaxValue, decimal.MinValue);

        Console.WriteLine("double datatype MaxValue : {0} and MinValue : {1} ", double.MaxValue, double.MinValue); // So double is greater than int

        Console.WriteLine("int datatype MaxValue : {0} and MinValue : {1}  ", int.MaxValue, int.MinValue);

        Console.WriteLine("long datatype MaxValue : {0} and MinValue : {1}  ", long.MaxValue, long.MinValue);



        bool b1 = false;
        Console.WriteLine(b1); //false

        bool b2 = true;
        Console.WriteLine(b2); // true


        char c1 = 'a';
        char c2 = 'b';
        Console.WriteLine(c1); // 'a'
        Console.WriteLine(c2); // 'a'


        string s1 = "John";
        string s2 = "1234_&*%#$#@!!QWDSSDUI,.,ggg_+";
        Console.WriteLine(s2);


        Console.ReadLine();




    }
}
