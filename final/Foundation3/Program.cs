using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address
        {
            _street = "9418 Mavondo Rd",
            _city = "Bulawayo",
            _state = "Bulawayo",
            _country = "Zimbabwe"
        };

        Event lecture = new Lecture("C# Language", "Learn how the program works", new DateTime(2024, 4, 09), "09:00 AM", address, "Prof. Nigel Ndlovu", 45);
        Event reception = new Reception("Wedding Reception", "Marriage celebration", new DateTime(2024, 4, 09), "8:00 PM", address, "nigel@nigel.com");
        Event outdoor = new Outdoor("Outing", "Visit the museum", new DateTime(2024, 3, 30), "12:00 PM", address, "Cloudy");

        Console.WriteLine("Event Details:");
        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\nReception:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\nOutdoor Gathering:");
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Descriptions:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine(outdoor.GetShortDescription());
    }
}