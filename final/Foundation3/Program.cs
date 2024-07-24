using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("555 Montes de Oca St", "Tijuana","22014", "Mexico");
        Address address2 = new Address("752 Golder Lantern St", "Carlsbad", "92008", "USA");
        Address address3 = new Address("582 Hills St", "San Marcos", "95016", "USA");

        Reception reception = new Reception(
            "Reception at the Beach",
            "A peacefully evening reception with music and food",
            new DateTime(2024, 8, 10),
            new TimeSpan(18, 0, 0),
            address1,
            new List<string> {"joivisvis@hotmail.com", "jordansanchez.connect@outlook.com"}
        );

        Lecture lecture = new Lecture(
            "Tech Conference",
            "A talk about the latest technologies",
            new DateTime(2024, 9, 5),
            new TimeSpan(14, 0, 0),
            address2,
            "Jordan Sanchez",
            150
        );

        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Basketball Tournament",
            "A tournament basketball",
            new DateTime(2024, 7, 20),
            new TimeSpan(10, 0, 0),
            address1,
            "Sunny and warm"
        );

        Console.WriteLine("Reception Full Message:");
        Console.WriteLine(reception.GenerateFullMessage());
        Console.WriteLine();

        Console.WriteLine("Lecture Full Message:");
        Console.WriteLine(lecture.GenerateFullMessage());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Full Message:");
        Console.WriteLine(outdoorGathering.GenerateFullMessage());
        Console.WriteLine();
        
    }
}