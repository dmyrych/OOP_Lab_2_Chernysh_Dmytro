using System;

namespace Lab_2_OOP
{
    public class Converter
    {
        public Currency EUR = new Currency();
        public Currency USD = new Currency();
        public Currency RUB = new Currency();
        public Converter(double usd, double eur, double rub)
        {
            EUR.value = eur;
            USD.value = usd;
            RUB.value = rub;
        }

        public double ConvertToUAH(double convertedExchange, double amountOfExchange)
        {
            double result = amountOfExchange * convertedExchange;
            Console.WriteLine($"Result of convertation is: {result}");
            return result; //Метод приймає значення курсу певної валюти а також кількість цієї валюти,
                           //після чого конвертує її в гривню та повертає значення.
        }                                               

        public double ConvertFromUAH(double convertedExchange, double amountOfUAH)
        {
            double result = amountOfUAH / convertedExchange; 
            Console.WriteLine($"Result of convertation from UAH is: {result}");
            return result; //Метод приймає значення курсу певної валюти а також кількість гривень які треба конвертувати,
                           //після чого конвертує гривню в валюту та повертає значення.
        }
    }

    public class Currency
    {
        public double value { get; set; }

    }
}
