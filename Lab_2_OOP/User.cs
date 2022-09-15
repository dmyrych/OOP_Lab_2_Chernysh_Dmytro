using System;
namespace Lab_2_OOP
{
    public class User
    {
        public string login { get; set; } = "Variagpro";
        public string name { get; set; } = "Mihaylo";
        public string surname { get; set; } = "Martynenko";
        public readonly DateTime registrationDate;

        public User()
        {
            registrationDate = DateTime.Now;
        }
        public User(string log, string firstName, string secondName)
        {
            registrationDate = DateTime.Now;
            login = log;
            name = firstName;
            surname = secondName;

        }
        public void Print()
        {
            Console.WriteLine($"Your current login is {login}");
            Console.WriteLine($"Your name seems to be {name}");
            Console.WriteLine($"Incredible! Turns out your surname is {surname}");
            Console.WriteLine($"You did register {registrationDate}");

        }
    }
}
