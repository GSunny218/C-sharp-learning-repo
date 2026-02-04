using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# comments.
            //int sunny = 33;
            /*
                Data types in C#
                Integer - int sunny; --> 4 bytes
                Floating point number - float that; --> 4 bytes
                Character - char a = 'A'; --> 2 bytes
                Boolean - bool isGreat = true; --> 1 bit
                String - string inp = "Sunny"; --> 2 bytes per character
                Long - long sunny --> 3 bytes
                Double - double sunny; --> 8 bytes
            */

            //string inp = Console.ReadLine();   // Taking input from user
            //Console.WriteLine(inp);
            //Console.WriteLine("Hello World");
            //Console.Write("Hello Sunny");
            //Console.WriteLine("I love C#"+ sunny);

            int a = 34;
            float b = 34.4F;  //here 'F' is compulsory
            double c = 34.4D; //here 'D' is optional
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}
