using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Greet(string name)
        {
            Console.WriteLine("Hello from Greet method! "+name);
        }

        static float Average(int a, int b)
        {
            return (a + b) / 2;
        }
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

            //int a = 34;
            //float b = 34.4F;  //here 'F' is compulsory
            //double c = 34.4D; //here 'D' is optional
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            // Type casting
            // There area two types of type casting in C#
            // 1. Implicit Type Casting (automatically)
            // char to int to long to float to double

            // 2. Explicit Type Casting (manually)
            // double to float to long to int to char
            // double a = (double) 3.5;
            //Console.WriteLine(a);
            //int a = (int) 3.5;

            //int x = 2;
            //double y = x; // Implicit Type Casting
            //float z = 'y';
            //float varr = Convert.ToInt64(3.55);
            //Convert.ToDouble
            //Convert.ToString
            //string sx = "34 is amazing";
            //string ax1 = "Random String";

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //Console.WriteLine("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hey Hello " + name);

            //Console.WriteLine("How many candy do you want?: ");
            //string can = Console.ReadLine();
            // Console.WriteLine("You will get 4 more candies " + Convert.ToInt32(can) + 4);         // Output: You will get 4 more candies 64
            //Console.WriteLine("You will get 4 more candies " + (Convert.ToInt32(can) + 4));       // Output: You will get 4 more candies 8

            /* Operators in C#
             1. Arithmetic Operators: +, -, *, /, %, ++, --
             2. Comparison Operators: ==, !=, >, <, >=, <=
             3. Logical Operators: &&, ||, !
             4. Assignment Operators: =, +=, -=, *=, /=, %=
            */

            // Arithmetic Operators
            //int a = 4;
            //int b = 2;
            //Console.WriteLine("a + b = " + (a + b));
            //Console.WriteLine("a - b = " + (a - b));
            //Console.WriteLine("a * b = " + (a * b));
            //Console.WriteLine("a / b = " + (a / b));

            // Assignment Operators
            //int a = 4;
            //int b = a;
            //b += 4;
            //b -= 4;
            //b *= 4;
            //b /= 4;
            // Consolae.WriteLine(b);

            // Logical Operators
            //Console.WriteLine(true && false);
            //Console.WriteLine(true || false);
            //Console.WriteLine(!false);
            //Console.WriteLine(!true);

            // Comparison Operators
            //Console.WriteLine(3 <= 4);
            //Console.WriteLine(5 > 6);
            //Console.WriteLine(7 != 8);

            // Math Functions
            //int a = Math.Max(35, 345);
            //int a = Math.Max(35, 345);
            //double a = Math.Sqrt(36);
            //double a = Math.Abs(-38);
            //Console.WriteLine(a);

            //string hello = "Hello world";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(string.Concat(hello, "You are nice"));

            //String ipterpolation
            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Your name is {name}. You will get {candies} candies");

            //String methods
            //string hello = "Hello \" world";
            //Console.WriteLine(hello[0]);
            //Console.WriteLine(hello.IndexOf("wo"));
            //Console.WriteLine(hello.Substring(5));

            //if-else conditions
            //Console.WriteLine("Enter your age: ");
            //string ageStr = Console.ReadLine();
            //int age = Convert.ToInt32(ageStr);
            //bool isBanned = true;
            //if (age < 2 && isBanned) {
            //    Console.WriteLine("You are just bron");
            //} else if (age > 18 || isBanned) {
            //    Console.WriteLine("You can drive");
            //} else {
            //    Console.WriteLine("You cannot drive");
            //}

            //switch case
            //int age = 78;
            //switch (age) {
            //    case 18:
            //        Console.WriteLine("Please wait for a year");
            //        break;
            //    case 20:
            //        Console.WriteLine("You're 20");
            //        break;
            //    default:
            //        Console.WriteLine("Enjoy");
            //        break;
            //}

            //Loops
            //while loop
            //int i = 0;
            //while (i < 5) {
            //    Console.WriteLine(i);
            //    i++;
            //}


            //do while
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i < 5);

            //for loop
            //for (int i = 0; i < 5; i++) {
            //    Console.WriteLine(i);
            //}

            //Methods
            //Greet("Sunny");
            //Console.WriteLine(Average(4, 5));

            //OOPS
            Player player1 = new Player();
            Console.WriteLine(player1.getHealth(90));
            player1.setHealth(50);

            Console.ReadLine();
        }
    }
}
