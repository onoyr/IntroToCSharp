namespace Exo12;

using System;

class Program
{
    // A company dealing with marketing wants to keep a data record of its
    // employees. Each record should have the following characteristic – first
    // name, last name, age, gender (‘m’ or ‘f’) and unique employee number
    // (27560000 to 27569999). Declare appropriate variables needed to
    // maintain the information for an employee by using the appropriate data
    // types and attribute names.
    static void Main(string[] args)
    {
        string firstName = "Sitraka";
        string lastName = "Ratsimba";
        byte age = 32;
        char gender = 'm';
        uint id = 26560001;

        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Id: " + id);
    }
}
