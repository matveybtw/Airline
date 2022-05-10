using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Airline
{
  public  class ServiceUser
    {
        static DataBaseContext context = new DataBaseContext();

        static bool ch = true;
        public static bool Add_User(string name,string lastName, string email, string pass)
        {
            ch = true;

            foreach (var item in context.Clients)
            {
                if (item.FirstName == name)
                {
                    ch = false;
                    MessageBox.Show("Таке ім'я вже існує!");
                    break;
                }

                if (item.Mail == email)
                {
                    MessageBox.Show("Такий логін вже існує ");
                    ch = false;
                    break;
                }

                if (name == "" || email == "" || pass == "" || name == " " || email == " " || pass == " " || name == "  " || email == "  " || pass == "  ") ////доробити
                {
                    MessageBox.Show("Пустий рядок не допустимий!");
                    ch = false;
                    break;
                }

            }

            if (ch)
            {
                context.Clients.Add(new Client { FirstName = name, LastName = lastName, Mail = email, Password = pass });
                context.SaveChanges();
                MessageBox.Show("Реєстрація пройшла успішно", "Реєстрація", MessageBoxButton.OK, MessageBoxImage.Information);
                return true;
            }
            else
                return false;
        }



        public static Client Get_User(string email, string pass)
        {


            foreach (var item in context.Clients)
            {

                if (item.Mail == email && item.Password == pass)
                {
                    return item;

                }

            }

            MessageBox.Show("Невірний логін або пароль!");
            return null;
        }


    }
}
