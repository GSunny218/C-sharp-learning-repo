using System;

public class Structures
{
    struct Person
    {
        public string name;
        public int age;
        public int birthMonth;
    }

    static void Main(string[] args) {
        //Structure
        string name = "Sunny";
        int age = 19;
        int birthMonth = 4;
        Person person;
        person.name = "Sunny";
        person.age = 19;
        person.birthMonth = 4;
        Console.WriteLine($"Name: {name}, Age: {age}, Birth Month: {birthMonth}");
        Console.WriteLine($"Name: {person.name}, Age: {person.age}, Birth Month: {person.birthMonth}");
    } 
}
