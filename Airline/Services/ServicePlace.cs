using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.Services
{
   public class ServicePlace
    {
        static DataBaseContext context = new DataBaseContext();

     public static List<Place> GetAll()
        {
            return context.Places.ToList();
        }


        public static void AddFull()
        {
            context.Places.Add(new Place { Title = "Київ" });
            context.Places.Add(new Place { Title = "Львів" });
            context.Places.Add(new Place { Title = "Дніпро" });
            context.Places.Add(new Place { Title = "Тернопіль" });
            context.Places.Add(new Place { Title = "Вінниця" });
            context.Places.Add(new Place { Title = "Харків" });
            context.Places.Add(new Place { Title = "Запоріжжя" });
            context.Places.Add(new Place { Title = "Хмельницький" });
            context.Places.Add(new Place { Title = "Рівне" });
            context.Places.Add(new Place { Title = "Полтава" });
            context.Places.Add(new Place { Title = "Одеса" });
            context.Places.Add(new Place { Title = "Луцьк" });
            context.Places.Add(new Place { Title = "Чернівці" });
            context.Places.Add(new Place { Title = "Черкаси" });
            context.Places.Add(new Place { Title = "Ужгород" });
            context.Places.Add(new Place { Title = "Кропивницький	" });
            context.Places.Add(new Place { Title = "Житомир" });
            context.Places.Add(new Place { Title = "Миколаїв" });
            context.Places.Add(new Place { Title = "Суми" });
            context.Places.Add(new Place { Title = "Чернігів" });
            context.Places.Add(new Place { Title = "Херсон" });
            context.Places.Add(new Place { Title = "Донецьк" });
            context.Places.Add(new Place { Title = "Луганськ" });
            context.Places.Add(new Place { Title = "Сімферополь" });
            context.SaveChanges();
        }
    }
}
