using System;

namespace Lab_2_OOP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Beginning of Task 1:");
            Address address = new Address();
            address.Print();

            Console.WriteLine("Beginning of Task 2");
            Converter converter = new Converter(36.73d, 36.73d, 0.63d);
            converter.ConvertToUAH(converter.EUR.value, 12);
            converter.ConvertFromUAH(converter.USD.value, 1100);

            Console.WriteLine("Beginning of Task 3");
            Employee employee = new Employee("Mihaylo", "Martynenko", 1, Positions.senior);
            employee.salaryCalc();

            Console.WriteLine("Beginning of Task 4");
            User user = new User();
            user.Print();
            User user2 = new User("dmyrych", "Dmytro", "Chernysh");
            user2.Print();
        }

    }
}
