using System;
using System.Collections.Generic; //For Dictionary and List
using System.Linq;
using System.Runtime.InteropServices; //For "Optional" keyword
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.Http;
using System.Threading;
using System.Data.SqlTypes;
using System.CodeDom;

namespace Hello
{
    class Person {
        private string name;
        private int age;
        /*public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = !string.IsNullOrEmpty(value) ? value : "Invalid name";
            }
        }*/
        public string Name { get => name; set => name = !string.IsNullOrEmpty(value) ? value : "Invalid name"; }   //With Arrow

        /*public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value >= 0 && value <= 150 ? value : -1;
            }
        }*/
        public int Age { get => age; set => age = value >= 0 && value <= 150 ? value : -1; }    //With Arrow

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Name = name;
            Age = age;
        }

        public string ReturnDetails() { 
            return $"Name: {name}, Age: {age}";
        }

    }

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

            /*string inp = Console.ReadLine();   // Taking input from user
            Console.WriteLine(inp);
            Console.WriteLine("Hello World");
            Console.Write("Hello Sunny");
            Console.WriteLine("I love C#" + sunny);*/

            /*int a = 34;
            float b = 34.4F;  //here 'F' is compulsory
            double c = 34.4D; //here 'D' is optional
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);*/

            /*Type casting
             There area two types of type casting in C#
             1.Implicit Type Casting(automatically)
             char to int to long to float to double

             2.Explicit Type Casting(manually)
             double to float to long to int to char
             double a = (double)3.5;
            Console.WriteLine(a);
            int a = (int)3.5;

            int x = 2;
            double y = x; // Implicit Type Casting
            float z = 'y';
            float varr = Convert.ToInt64(3.55);
            Convert.ToDouble
            Convert.ToString
            string sx = "34 is amazing";
            string ax1 = "Random String";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hey Hello " + name);

            Console.WriteLine("How many candy do you want?: ");
            string can = Console.ReadLine();
            Console.WriteLine("You will get 4 more candies " + Convert.ToInt32(can) + 4);         // Output: You will get 4 more candies 64
            Console.WriteLine("You will get 4 more candies " + (Convert.ToInt32(can) + 4));       // Output: You will get 4 more candies 8
            */

            /* Operators in C#
             1. Arithmetic Operators: +, -, *, /, %, ++, --
             2. Comparison Operators: ==, !=, >, <, >=, <=
             3. Logical Operators: &&, ||, !
             4. Assignment Operators: =, +=, -=, *=, /=, %=
            */

            /*Arithmetic Operators
            int a = 4;
            int b = 2;
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));*/

            /*Assignment Operators
            int a = 4;
            int b = a;
            b += 4;
            b -= 4;
            b *= 4;
            b /= 4;
            Consolae.WriteLine(b);*/

            /*Logical Operators

           Console.WriteLine(true && false);
            Console.WriteLine(true || false);
            Console.WriteLine(!false);
            Console.WriteLine(!true);*/

            /*Comparison Operators

           Console.WriteLine(3 <= 4);
            Console.WriteLine(5 > 6);
            Console.WriteLine(7 != 8);*/

            /*Math Functions
            int a = Math.Max(35, 345);
            int a = Math.Max(35, 345);
            double a = Math.Sqrt(36);
            double a = Math.Abs(-38);
            Console.WriteLine(a);*/

            /*var keyword
            var name = "Sunny";*/

            /*(const keyword
             const float pi = 3.14F;*/

            /*Numeric Formatting
            double value = 1000D / 12.34D;
            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0} {1}", value, 10000));
            Console.WriteLine(string.Format("{0:0.0}", value));
            Console.WriteLine(string.Format("{0:0.00}", value));
            Console.WriteLine(string.Format("{0:0.000}", value));
            Console.WriteLine(value.ToString("C"));
            Console.WriteLine(value.ToString("C0"));
            Console.WriteLine(value.ToString("C1"));
            Console.WriteLine(value.ToString("C2"));

            Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));*/

            /*TryParse method
            bool success = true;
            while (success)
            {
                Console.WriteLine("Enter a number: ");
                string numInput = Console.ReadLine();
                if (int.TryParse(numInput, out int num))
                {
                    success = false;
                    Console.WriteLine("You entered: " + num);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }*/

            /*Exceptions handling
            try
            {
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Please enter a number less than 2 billion");
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please only enter number!");
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine($"Error: {e.Message}");
            }*/

            //OOPS
            //Player player1 = new Player();
            //Console.WriteLine(player1.getHealth(90));
            //player1.setHealth(50);

            //Class Fields
            Person person = new Person("Sunny", 19);
            Console.WriteLine($"Details: {person.ReturnDetails()}");
            person.Name = "Sahil";
            person.Age = 19;
            Console.WriteLine($"Details: {person.ReturnDetails()}");

            Console.ReadLine();
        }
    }
}
