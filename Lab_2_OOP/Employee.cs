using System;
namespace Lab_2_OOP
{
    public enum Positions
    {
        junior = 100,
        middle = 400,
        senior = 1000,
        accountant = 300,
        janitor = -100,
        manager = 400,
    }
    public class Employee
    {
        public Positions position { get; set; } = Positions.junior;
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int yearsOfExperience { get; set; }
        public Employee()
        {
            FirstName = "John";
            SecondName = "Smith";
            yearsOfExperience = 1066;
        }
        public Employee(string first, string second, int experience, Positions pos)
        {
            FirstName = first;
            SecondName = second;
            yearsOfExperience = experience;
            position = pos;
        }
        public int salaryCalc()
        {
            int taxPercent = 18;
            int tax;
            int baseSalary = 400;
            int positionBonus = (int)position;
            Console.WriteLine($"Position bonus is {positionBonus} dollars!");
            int totalSalary = baseSalary + positionBonus * (1 + yearsOfExperience / 10); //Вважаю кількість років досвіду в обрахуванні зарплатні як коефіцієнт
            tax = (totalSalary / 100) * taxPercent;                                                                          //та домножую на нього(В перерахунку 1 рік як 0.1 бал коефіцієнту)
            totalSalary -= tax;
            Console.WriteLine($"Total salary is {totalSalary} dollars with {tax} dollars of tax!");
            return totalSalary;
        }
    }
}
