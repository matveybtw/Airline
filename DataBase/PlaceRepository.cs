using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBase
{
    public interface IPlaceRepository : IBaseRepository<Place, int>
    {

    }
    public class PlaceRepository : BaseRepository<Place, int>, IPlaceRepository
    {

    }
}