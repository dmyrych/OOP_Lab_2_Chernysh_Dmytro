using System;
namespace Lab_2_OOP
{
    public class Address
    {
        public int index { get; set; } = 14880;
        public string country { get; set; } = "Ukraine";
        public string city { get; set; } = "Kyiv";
        public string street { get; set; } = "Bratyslavska";
        public int house { get; set; } = 6;
        public int apartament { get; set; } = 9;




        public void Print()
        {
            Console.WriteLine($"index {index}");
            Console.WriteLine($"country {country}");
            Console.WriteLine($"city {city}");
            Console.WriteLine($"street {street}");
            Console.WriteLine($"house {house}");
            Console.WriteLine($"apartament {apartament}");

        }
    }

}
