using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBase
{
    public interface IFlightRepository : IBaseRepository<Flight, int>
    {

    }
    public class FlightRepository : BaseRepository<Flight, int>, IFlightRepository
    {
        public IEnumerable<Flight> FlightsList(DateTime date)
        {
            var list = new List<Flight>();
            foreach (var item in GetAll())
            {
                if (item.date==date)
                {
                    list.Add(item);
                }
            }
            return list;
        }
        public int FreePlaces(Flight flight)
        {
            int count = 0;
            var btrep = new BookedTicketRepository();
            foreach (var item in btrep.GetAll())
            {
                if (item.Flight==flight)
                {
                    count++;
                }
            }
            return flight.MaxClients - count;
        }
    }
}