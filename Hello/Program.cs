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
    internal class Program
    {
        //static void Greet(string name)
        //{
        //    Console.WriteLine("Hello from Greet method! "+name);
        //}

        //static float Average(int a, int b)
        //{
        //    return (a + b) / 2;
        //}
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

            //var keyword
            //var name = "Sunny";

            //const keyword
            // const float pi = 3.14F;

            //Numeric Formatting
            //double value = 1000D / 12.34D;
            //Console.WriteLine(value);
            //Console.WriteLine(string.Format("{0} {1}",value,10000));
            //Console.WriteLine(string.Format("{0:0.0}", value));
            //Console.WriteLine(string.Format("{0:0.00}",value));
            //Console.WriteLine(string.Format("{0:0.000}", value));
            //Console.WriteLine(value.ToString("C"));
            //Console.WriteLine(value.ToString("C0"));
            //Console.WriteLine(value.ToString("C1"));
            //Console.WriteLine(value.ToString("C2"));

            //Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));
            //Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            //Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

            //TryParse method
            //bool success = true;
            //while (success) {
            //    Console.WriteLine("Enter a number: ");
            //    string numInput = Console.ReadLine();
            //    if (int.TryParse(numInput, out int num))
            //    {   
            //        success = false;
            //        Console.WriteLine("You entered: " + num);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input");
            //    }
            //}

            //Verbatim string literal
            // \t \n \\ \" = \
            //string filePath = "C:\\Users\\Sunny\\Desktop\\file.txt";
            //string filePath = @"C:\Users\Sunny\Desktop\file.txt";
            //string speech = "He said \"something\"";
            //string speech = @"He said ""something""";
            //sring speech = "He said \\something\\";
            //string speech = @"He said \something\";
            //string speech = "Hello 'someone'";

            //string hello = "Hello world";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(string.Concat(hello, "You are nice"));

            //String interpolation
            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Your name is {name}. You will get {candies} candies");

            //String Empty
            //string name = string.Empty;
            //if (name != string.Empty) {
            //    Console.WriteLine("Name is not empty");
            //} else {
            //    Console.WriteLine("Name is empty");
            //}
            //Console.WriteLine(name);

            //String equals function
            //string message = "Hello";     // Ex 1
            //string compare = "Hello";
            //if (message.Equals(compare)) {
            //    Console.WriteLine("Strings are equal");
            //} else {
            //    Console.WriteLine("Strings are not equal");
            //}
            //string name = "";            // Ex 2
            //if (name.Equals(""))
            //{
            //    Console.WriteLine("Name is empty");
            //}
            //else {                 
            //    Console.WriteLine("Name is not empty");
            //}
            //char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
            //string newCompare = new string(chars);
            //if (message.Equals(newCompare)) {
            //    Console.WriteLine("Strings are equal");
            //} else {
            //    Console.WriteLine("Strings are not equal");
            //}
            //string messege = "C# is awesome";
            //for (int i = 0; i < messege.Length; i++) {
            //    Console.WriteLine(message[i]);
            //}

            //String iteration looping
            //for (int i = 0; i < messege.Length; i++) {
            //    Console.Write(messege[i]);
            //    Thread.Sleep(1000);   //1000ms = 1sec
            //}

            //String null or empty
            //Console.WriteLine("Enter name: ");
            //string name = null;
            //if (string.IsNullOrEmpty(name)) {
            //    Console.WriteLine("name is empty");
            //}

            //Print a string in reverse
            //Console.WriteLine("Enter: ");
            //string message = Console.ReadLine();
            //for (int i = message.Length - 1; i >= 0; i--) { 
            //    Console.Write(message[i]);
            //}

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

            //Array
            //Console.WriteLine("Enter length of array: ");
            //int arrLength = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[10];
            //int[] numbers = new int[arrLength];
            //Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");
            //for (int i = 0; i < numbers.Length; i++) {
            //    Console.WriteLine("Enter a number: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
            //foreach (var num in numbers)
            //{
            //    Console.Write($"{num} ");
            //}
            //const int angleCount = 3;
            //int[] angles = new int[angleCount];
            //for (int i = 0; i < angleCount; i++) {
            //    Console.WriteLine($"Enter angle{i+1}: ");
            //    angles[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int angleSum = 0;
            //for (int i = 0; i < angleCount; i++) {
            //    angleSum += angles[i];
            //}
            //Console.WriteLine(angleSum);
            //Console.WriteLine(angleSum == 100 ? "Valid" : "Invalid");

            //Array Sorting
            //int[] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            //Array.Sort(numbers);
            //foreach (var num in numbers)
            //{
            //    Console.Write($"{num} ");
            //}
            //Array Reversal
            //int[] numbers = new int[] { 0, 1, 2, 3, 4, 5 };
            /*Array.Reverse(numbers);
            foreach (var num in numbers)
            {
                Console.Write($"{num} ");
            }*/
            //int[] sortedNumbers = new int[numbers.Length];    //Alternative to Array.Reverse() method
            //int x = 0;
            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    sortedNumbers[x] = numbers[i];
            //    x++;
            //}
            //foreach (var num in sortedNumbers)
            //{
            //    Console.Write($"{num} ");
            //}

            //Array clearing
            //int[] numbers = new int[] { 0, 1, 2, 3, 4,5,6,7,8,9};
            //Array.Clear(numbers, 0, numbers.Length);
            //foreach (var num in numbers)
            //{
            //    Console.Write($"{num} ");
            //}
            //for (int i = 0; i < numbers.Length; i++) {
            //    numbers[i] = default;
            //}
            //Array.Clear(numbers, 5, 5);
            //foreach (var num in numbers)
            //{
            //    Console.Write($"{num} ");
            //}

            //Array IndexOf
            //int[] numbers = new int[] { 90, 199, 50, 30 };
            //Console.Write("Enter number to search: ");
            //int search = Convert.ToInt32(Console.ReadLine());
            //int position = Array.IndexOf(numbers, search, 1, 3);      //1 is the starting index and 3 is the count of elements to search
            //if (position > -1)
            //{
            //    Console.WriteLine($"Number {search} has been found at position {position + 1}");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {search} has not been found");
            //}

            //Lists
            //List<int> listNumber = new List<int>();
            //for (int i = 0; i < 3; i++) {
            //    Console.WriteLine("Enter a number: ");
            //    listNumber.Add(Convert.ToInt32(Console.ReadLine()));
            //}
            //for (int i = 0; i < listNumber.Count; i++) {
            //    Console.WriteLine(listNumber[i]);
            //}
            //listNumber.RemoveAt(1);
            //foreach (int num in listNumber) {
            //    Console.WriteLine(num);
            //}

            //Dictionary
            //Dictionary<int, string> names = new Dictionary<int, string> {
            //    //Key pairs
            //    {1, "Sunny"},
            //    {2, "Saurabh"},
            //    {3, "Sahil"}
            //};
            //for (int i = 0; i < names.Count; i++) { 
            //    KeyValuePair<int, string> pair = names.ElementAt(i);
            //    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            //}
            //foreach (KeyValuePair<int, string> item in names)
            //{
            //    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //}
            //Dictionary<string, string> teacher = new Dictionary<string, string>
            //{
            //    {"Maths", "Pushpa"},
            //    {"SPM", "Divya"}
            //};
            ////Console.WriteLine(teacher["maths"]); //Does'nt work
            //if (teacher.TryGetValue("Maths", out string teachers))
            //{
            //    Console.WriteLine(teachers);
            //    teacher["Math"] = "Joe";
            //}
            //else { 
            //    Console.WriteLine("Math teacher not found");
            //}
            //if (teacher.ContainsKey("SPM"))
            //{
            //    teacher.Remove("SPM");
            //}
            //else {
            //    Console.WriteLine("SPM teacher not found");
            //}
            //foreach (KeyValuePair<string, string> item in teacher)
            //{
            //    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //}

            //Methods
            //Greet("Sunny");
            //Console.WriteLine(Average(4, 5));

            //Optional parameters
            //Console.WriteLine(Add(5));

            //Named parameter
            //string nameInput = "Sunny";
            //int ageInput = 19;
            //string addressInput = "Lal Dongar";
            //PrintDetails(address: addressInput, age: ageInput, name: nameInput);

            //Out parameters
            //int num = 0;
            //test(out num);
            //Console.WriteLine(num);

            //Reference parameter
            //int num = 10;                  //1
            //string name = "Sunny";
            //Assign(ref num, ref name);
            //Console.WriteLine(num);
            //Console.WriteLine(name);
            //string name = "Sunny";                  //2
            //Console.Write("Enter your new name: ");
            //string newName = Console.ReadLine();
            //ChangeName(ref name, newName);
            //Console.WriteLine($"New Name: {name}");

            //OOPS
            //Player player1 = new Player();
            //Console.WriteLine(player1.getHealth(90));
            //player1.setHealth(50);

            Console.ReadLine();
        }

        //Optional parameters function
        //static int Add(int a, int b = default) {
        //    return a + b;
        //}

        //Named parameter function
        //static void PrintDetails(string name, int age, string address) {
        //    Console.WriteLine($"Name: {name}");
        //    Console.WriteLine($"Age: {age}");
        //    Console.WriteLine($"Address: {address}");
        //}

        //Out parameter function
        //static void test(out int num) {
        //    num = 5;
        //}

        //Reference parameter function
        //static void Assign(ref int num, ref string name) {  //1
        //    name = "Sahil"; 
        //    num = 20;
        //}
        //static void ChangeName(ref string name, string newName) {   //2
        //    name = newName;
        //}
    }
}
