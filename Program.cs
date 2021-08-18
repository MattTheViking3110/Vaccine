using System;

namespace Vaccine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the vaccine registration.");
            Console.WriteLine("Please fill in your information:");
            Console.WriteLine("");

            Console.Write("Your ID :");
            String ID = Console.ReadLine();

            Console.Write("Your First name :");
            String fName = Console.ReadLine();

            Console.Write("Your Surname:");
            String sName = Console.ReadLine();

            Console.Write("Your Gender:");
            String gender = Console.ReadLine();

            Console.Write("Your Date Of Registration:");
            String DOR = Console.ReadLine();

            Console.Write("Your Province:");
            String Province = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Thank you for considering vaccination");
            Console.WriteLine("");
            Console.WriteLine("Your Info:");
            Console.WriteLine("ID:" + ID);
            Console.WriteLine("First name:" + fName);
            Console.WriteLine("Surname:" + sName);
            Console.WriteLine("Gender:" + gender);
            Console.WriteLine("Date of Registration" + DOR);
            Console.WriteLine("Province:" + Province);
        }
    }
}
