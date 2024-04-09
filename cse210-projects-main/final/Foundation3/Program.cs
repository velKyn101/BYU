using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Cityville", "USA");
        Lecture lecture = new Lecture("Introduction to AI", "Learn about artificial intelligence", new DateTime(2024, 4, 10), "10:00 AM", address1, "John Smith", 50);

        Address address2 = new Address("432 Elm Street", "Townsvile", "Canada");
        Reception reception = new Reception("Networking Event", "Meet professionals in the industry", new DateTime(2024, 4, 15), "6:00 PM", address2, "info@example.com");

        Address address3 = new Address("Rua do Pão de Queijo, 142", "Belo Horizonte", "BR");
        OutdoorGathering outdoor = new OutdoorGathering("Hiking Trip", "Explore the nearby mountains", new DateTime(2024, 4, 20), "8:00 AM", address3, "Sunny");

        Console.WriteLine("Standard Details: ");
        Console.WriteLine(lecture.GetStandardDetails() + "\n");

        Console.WriteLine("Full Details: ");
        Console.WriteLine(lecture.GetFullDetails() + "\n");

        Console.WriteLine("Short Details: ");
        Console.WriteLine(lecture.GetShortDetails() + "\n");

        Console.WriteLine("Standard Details: ");
        Console.WriteLine(reception.GetStandardDetails() + "\n");

        Console.WriteLine("Full Details: ");
        Console.WriteLine(reception.GetFullDetails() + "\n");

        Console.WriteLine("Short Details: ");
        Console.WriteLine(reception.GetShortDetails() + "\n");

        Console.WriteLine("Standard Details: ");
        Console.WriteLine(outdoor.GetStandardDetails() + "\n");

        Console.WriteLine("Full Details: ");
        Console.WriteLine(outdoor.GetFullDetails() + "\n");

        Console.WriteLine("Short Details: ");
        Console.WriteLine(outdoor.GetShortDetails() + "\n");
    }
}