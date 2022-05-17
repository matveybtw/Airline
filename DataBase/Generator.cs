using Bogus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public static class Generator
    {
        public static void GenerateClients(int count)
        {
            var faker = new Faker<Client>("uk").
            RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName()).
            RuleFor(u => u.LastName, (f, u) => f.Name.LastName()).
            RuleFor(u => u.Mail, (f, u) => f.Internet.Email()).
            RuleFor(u => u.Password, (f, u) => f.Internet.Password());
            var unit = new UnitOfWork();
            for (int i = 0; i < count; i++)
            {
                unit.ClientRepository.Add(faker.Generate());
            }
        }
        public static void GeneratePlaces(int count)
        {
            var faker = new Faker<Place>("uk").
            RuleFor(u => u.Title, (f, u) => f.Address.City());
            var unit = new UnitOfWork();
            for (int i = 0; i < count; i++)
            {
                unit.PlaceRepository.Add(faker.Generate());
            }

        }
        public static void GenerateFlights(int count)
        {
            var rand = new Random();
            var unit = new UnitOfWork();
            var faker = new Faker<Flight>("uk").
                RuleFor(u => u.date, (f, u) => f.Date.Soon(5)).
                RuleFor(u => u.Cost, (f, u) => f.Random.Decimal(1000, 10000));
            var places = new List<int>() { 100, 150, 200, 250, 300, 350, 400 };
            for (int i = 0; i < count; i++)
            {
                var flight = faker.Generate();
                flight.FromId = unit.PlaceRepository.GetAll().ToList()[rand.Next(0, unit.PlaceRepository.GetAll().Count()-1)].Id;
                flight.ToId = unit.PlaceRepository.GetAll().ToList()[rand.Next(0, unit.PlaceRepository.GetAll().Count()-1)].Id;
                flight.MaxClients = places[rand.Next(0, places.Count - 1)];
                unit.FlightRepository.Add(flight);
            }
        }
        public static void GenerateBookedTickets(int count)
        {
            var rand = new Random();
            var unit = new UnitOfWork();
            for (int i = 0; i < count; i++)
            {
                var bt = new BookedTicket()
                {
                    ClientId = unit.ClientRepository.GetAll().ToList()[rand.Next(0, unit.ClientRepository.GetAll().Count()-1)].Id,
                    FlightId = unit.FlightRepository.GetAll().ToList()[rand.Next(0, unit.FlightRepository.GetAll().Count()-1)].Id
                };
                unit.BookedTicketRepository.Add(bt);
            }
        }

    }
}