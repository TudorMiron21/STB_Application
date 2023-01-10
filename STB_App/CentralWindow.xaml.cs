using STB_App.Models;
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

namespace STB_App
{
    /// <summary>
    /// Interaction logic for CentralWindow.xaml
    /// </summary>
    public partial class CentralWindow : Window
    {
        public string password { get; set; }
        public int PersonId { get; set; }

        public CentralWindow()
        {
            InitializeComponent();
        }

        public CentralWindow(string password):this()
        {
           this.password = password;
           InitializeComponent();
        }

        private void buy_ticket_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buy_subscription_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ticket_history_Click(object sender, RoutedEventArgs e)
        {

        }

        private void subscription_history_Click(object sender, RoutedEventArgs e)
        {

        }

        private void my_profile_Click(object sender, RoutedEventArgs e)
        {
            STB_appContext STB_context = new STB_appContext();
            var user = from u in STB_context.Person
                       where u.Passw == this.password
                       select new
                       {
                            u.PersonId,
                            u.Passw,
                            u.UserName,
                            u.Email,
                            u.CategoryId,
                            u.FirstName,
                            u.SecondName,
                            u.PhoneNumber
                       };
            this.PersonId = user.First().PersonId;

            MyProfile objMyProfile = new MyProfile(this.PersonId,(int)user.First().CategoryId,user.First().Email,user.First().PhoneNumber,user.First().FirstName,user.First().SecondName,user.First().UserName);

            this.Visibility = Visibility.Hidden;
            objMyProfile.Show();

        }

        private void insert_card_Click(object sender, RoutedEventArgs e)
        {

        }

        private void minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void view_routes_Click(object sender, RoutedEventArgs e)
        {
            ShowRoutes objViewRoutes = new ShowRoutes();
            objViewRoutes.Left = this.Left;
            objViewRoutes.Top = this.Top;
            objViewRoutes.Width = this.Width;
            objViewRoutes.Height = this.Height;
            objViewRoutes.Show();

            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //back to login window
            MainWindow objMainWindow = new MainWindow();
            objMainWindow.Left = this.Left;
            objMainWindow.Top = this.Top;
            objMainWindow.Width = this.Width;
            objMainWindow.Height = this.Height;

            objMainWindow.Show();

            this.Close();
        }
    }
}
