using System;
namespace LegacyApp
{
    public class AddressMaster
    {
        public string City { get; }
        public string Street { get; }

        public AddressMaster(string city, string street)   // constructor with parameters
        {
            City = city;
            Street = street;
        }

        public void ShowAddress()
        {
            Console.WriteLine($"Address: {Street}, {City}");
        }
    }
}
