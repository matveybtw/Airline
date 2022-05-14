using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.Services
{
  public  class ServiceFlight
    {
        static DataBaseContext context = new DataBaseContext();

        public static List<Flight> GetFlight(DateTime date , string from ,string to)
        {
            List<Flight> list = new List<Flight>();
            foreach (var item in context.Flights.ToList())
            {
                if(item.date.Year== date.Year&& item.date.Month == date.Month 
                    && item.date.Day == date.Day && item.From.Title==from&&item.To.Title==to )
                {
                    list.Add(item);
                }
            }
            return list;
        }

  


        public static List<Flight> GetAll()
        {
            return context.Flights.ToList();
          
        }

        public static void AddFull()//Рейси 14:15   -- 18:45  --22:10
        {
          

            for(int i =0;i<5;i++)
                for(int j = 0;j<29;j++)
                {

                    foreach (Place place_from in ServicePlace.GetAll())
                    {

                        foreach (Place place_to in ServicePlace.GetAll())
                        {

                            if (place_from != place_to)
                            {

                                context.Flights.Add(new Flight
                                {
                                    From = new Place() { Title = place_from.Title},
                                    To = new Place() { Title = place_to.Title },
                                    MaxClients = 50,
                                    Cost = 35,
                                    date = new DateTime(2022, 5 + i, 1 + j, 14, 15, 0)
                                });
                                //context.Flights.Add(new Flight
                                //{
                                //    From = place_from,
                                //    To = place_to,
                                //    MaxClients = 50,
                                //    Cost = 35,
                                //    date = new DateTime(2022, 5 + i, 1 + j, 18, 45, 0)
                                //});
                                //context.Flights.Add(new Flight
                                //{
                                //    From = place_from,
                                //    To = place_to,
                                //    MaxClients = 50,
                                //    Cost = 35,
                                //    date = new DateTime(2022, 5 + i, 1 + j, 22, 10, 0)
                                //});
                                context.SaveChanges();
                            }
                        }
                    }



                }


         
       

        }
    }

}

