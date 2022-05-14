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
    /// Interaction logic for WinRegister.xaml
    /// </summary>
    public partial class WinRegister : Window
    {
        public WinRegister()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (ServiceUser.Add_User(Name_txbx.Text, LastName_txbx.Text, Email_txbx.Text, Pass_txbx.Text))
                this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
         
            this.Close();
        }
    }
}
