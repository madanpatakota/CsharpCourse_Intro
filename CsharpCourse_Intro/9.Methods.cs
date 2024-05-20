using System;

/*f10 for next line
  f11 when you are at method press f11 (defination of that method)
 */

class Methods
{


    //Main is a method entry method under the Methods Class
    static void Main()
    {
        Console.WriteLine("Start - Running");
        Method1(); //Calling method1;
        Method2();
        Console.ReadLine();
    }


    static void Method1()
    {
        Console.WriteLine("Method1 is calling");
    }
    static void Method2()
    {
        Console.WriteLine("Method2 is calling");
        Method3();
    }

    static void Method3()
    {
        Console.WriteLine("Method3 is calling");
    }



}

