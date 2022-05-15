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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataBase;
namespace Airline
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WinRegister registerWin;
        AirlineWin WinAir;
        public MainWindow()
        {
            InitializeComponent();
            //Generator.GenerateClients(100);
            //Generator.GeneratePlaces(100);
            //Generator.GenerateFlights(100);
            //Generator.GenerateBookedTickets(100);
            
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            lab.Foreground = Brushes.Red;
        }

        private void Label_MouseLeave(object sender, MouseEventArgs e)
        {
            lab.Foreground = Brushes.Blue;
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            registerWin = new WinRegister();
            registerWin.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var clien = ServiceUser.Get_User(email_txbx.Text, pass_txbx.Text);

            if (clien != null)
            {
                WinAir = new AirlineWin(clien);
                WinAir.Show();
                this.Close();

            }
        }


    }

}

