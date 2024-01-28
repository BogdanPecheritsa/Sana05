using System;

namespace Sana05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Airplane ---");
            Airplane airplane1 = new Airplane("Zhytomyr", "Rivne", new MyDate(2024, 5, 13, 19, 46), new MyDate(2024, 5, 13, 22, 14));
            Console.WriteLine($"Start City: {airplane1.StartCity}, Finish City: {airplane1.FinishCity}");
            Console.WriteLine($"Start Date: {airplane1.StartDate.Year}/{airplane1.StartDate.Month}/{airplane1.StartDate.Day} {airplane1.StartDate.Hours}:{airplane1.StartDate.Minutes}");
            Console.WriteLine($"Finish Date: {airplane1.FinishDate.Year}/{airplane1.FinishDate.Month}/{airplane1.FinishDate.Day} {airplane1.FinishDate.Hours}:{airplane1.FinishDate.Minutes}");
            Console.WriteLine($"Total Time: {airplane1.GetTotalTime()} minutes");
            Console.WriteLine($"Is Arriving Today? {airplane1.IsArrivingToday()}");

            Console.WriteLine("\n--- Currency ---");
            Currency currency1 = new Currency("USD", 37.87);
            Console.WriteLine($"Currency Name: {currency1.Name}, Exchange Rate: {currency1.ExRate}");

            Console.WriteLine("\n--- MyDate ---");
            MyDate date1 = new MyDate(2024, 1, 28, 18, 32);
            Console.WriteLine($"Date: {date1.Year}/{date1.Month}/{date1.Day} {date1.Hours}:{date1.Minutes}");

            Console.WriteLine("\n--- Product ---");
            Product product1 = new Product("Laptop", 359.99, currency1, 60, "ManufacturerX", 2.5);
            Console.WriteLine($"Product: {product1.Name}, Price: {product1.Price}, Quantity: {product1.Quantity}");
            Console.WriteLine($"Total Price in UAH: {product1.GetTotalPriceInUAH()}");
            Console.WriteLine($"Total Weight: {product1.GetTotalWeight()} kg");
        }
    }
}