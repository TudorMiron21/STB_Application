using STB_App.Models;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
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
    /// Interaction logic for MyProfile.xaml
    /// </summary>
    public partial class MyProfile : Window 
    {
        
        public int PersonId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName {get; set; }

        public int CategoryId { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }


        public MyProfile()
        {
            InitializeComponent();
        }
        public MyProfile(int PersonId, int categoryId, string email, string phone ,string LastName , string FirstName, string Useraname) : this()
        {
           
            this.PersonId = PersonId;
            CategoryId = categoryId;
            Email = email;
            Phone = phone;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.UserName = Useraname;

            this.Username_content.Text = this.UserName;
            this.FirstName_content.Text = this.FirstName;
            this.LastName_content.Text = this.LastName;
            this.Email_content.Text = this.Email;
            this.Phone_content.Text = this.Phone;


            
            //this.FavouriteRoute_content = 

            using (var context = new STB_appContext())
            {
                var no_subscription = from subs in context.SubscriptionHistory
                                      where subs.PersonId == PersonId
                                      select subs;

                this.NoSubscriptions_content.Text = no_subscription.Count().ToString();

                var no_tickets=from subs in context.TicketHistory
                               where subs.PersonId == PersonId
                               select subs;
                this.NoTickets_content.Text = no_tickets.Count().ToString();


               /* var favourite_route = from person in context.Person
                                      select */
            }

            InitializeComponent();

        }

        private void minimize_Click(object sender, RoutedEventArgs e)
        {

        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            System.Windows.Application.Current.Shutdown(); 
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {

            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(CentralWindow))
                    window.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
        }


    }
}
