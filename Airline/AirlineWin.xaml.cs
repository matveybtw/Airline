using Airline.Services;
using DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Airline
{
    /// <summary>
    /// Interaction logic for AirlineWin.xaml
    /// </summary>
    public partial class AirlineWin : Window
    {
        bool check_btn1 = false;
        bool check_btn2 = true;
   
        public AirlineWin(Client client)
        {
            InitializeComponent();
      

            User_txt.Text = client.FirstName + " " + client.LastName;

            Data_txtblok.Text = $"{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}";


            foreach(var item in ServicePlace.GetAll())
            {
                from_combo.Items.Add(item.Title);
                To_combo.Items.Add(item.Title);
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void calendar1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Data_txtblok.Text = $"{calendar1.SelectedDate.Value.Day}.{calendar1.SelectedDate.Value.Month}.{calendar1.SelectedDate.Value.Year}";

            if(calendar1.SelectedDate.Value< DateTime.Now)
                check_btn2 = false;
            else
                check_btn2 = true;

            if(check_btn2==true&& check_btn1 == true)
             Poshuk_btn.IsEnabled = true;
            else
                Poshuk_btn.IsEnabled = false;
        }


        private void from_combo_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (from_combo.SelectedItem == To_combo.SelectedItem)
                check_btn1 = false;
            else
                check_btn1 = true;

            if (check_btn2 == true && check_btn1 == true)
                Poshuk_btn.IsEnabled = true;
            else
                Poshuk_btn.IsEnabled = false;
        }

        private void Poshuk_btn_Click(object sender, RoutedEventArgs e)
        {
            foreach(var item in ServiceFlight.GetFlight(calendar1.SelectedDate.Value, from_combo.Text, To_combo.Text))
            {
                Listbox.Items.Add(item);
            }


        }
    }
}
