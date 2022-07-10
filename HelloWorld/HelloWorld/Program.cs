// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Estoy aprendiendo C#");
            Console.WriteLine("Wo juede hen haowan");
            // Console.Write = System.out.print
            // Console.WriteLine = System.out.println
            Console.Write("Foo");
            Console.Write("bar\n");
            string myString = "korvasieni";
            const int myNum = 20;
            Console.WriteLine(myString);
            double myDouble = 55.099D;
            float myFloat = 14.09F;
            Console.WriteLine("My double is: " + myDouble);
            Console.WriteLine("My float is: " + myFloat);
            bool isBool = true;
            Console.WriteLine(isBool);
            /*
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
            */
        }
    }
}
