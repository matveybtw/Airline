using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBase
{
    public interface IClientRepository : IBaseRepository<Client, int>
    {

    }
    public class ClientRepository : BaseRepository<Client, int>, IClientRepository
    {

    }
}