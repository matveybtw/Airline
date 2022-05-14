using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBase
{
    public interface IBookedTicketRepository : IBaseRepository<BookedTicket, int>
    {

    }
    public class BookedTicketRepository : BaseRepository<BookedTicket, int>, IBookedTicketRepository
    {

    }
}