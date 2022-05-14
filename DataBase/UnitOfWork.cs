using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataBase
{
    public class UnitOfWork : IDisposable
    {
        private DataBaseContext _context = new DataBaseContext();
        private IPlaceRepository _placeRepository;
        private IFlightRepository _flightRepository;
        private IClientRepository _clientRepository;
        private IBookedTicketRepository _bookedTicketRepository;

        public IPlaceRepository PlaceRepository
        {
            get
            {
                _placeRepository = _placeRepository ?? new PlaceRepository();
                return _placeRepository;
            }
        }

        public IFlightRepository FlightRepository
        {
            get
            {
                _flightRepository = _flightRepository ?? new FlightRepository();
                return _flightRepository;
            }
        }
        public IClientRepository ClientRepository
        {
            get
            {
                _clientRepository = _clientRepository ?? new ClientRepository();
                return _clientRepository;
            }
        }
        public IBookedTicketRepository BookedTicketRepository
        {
            get
            {
                _bookedTicketRepository = _bookedTicketRepository ?? new BookedTicketRepository();
                return _bookedTicketRepository;
            }
        }
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}