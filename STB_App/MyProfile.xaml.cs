using STB_App.Models2;
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
        public MyProfile(int PersonId) : this()
        {

            STB_appContext STB_context = new STB_appContext();
            var user = from u in STB_context.Person
                       where u.PersonId == this.PersonId
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

            this.PersonId = PersonId;
            CategoryId = (int)user.First().CategoryId;
            Email = user.First().Email;
            Phone = user.First().PhoneNumber;
            this.LastName = user.First().SecondName;
            this.FirstName = user.First().FirstName;
            this.UserName = user.First().UserName;

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

                var no_tickets = from subs in context.TicketHistory
                                 where subs.PersonId == PersonId
                                 select subs;
                this.NoTickets_content.Text = no_tickets.Count().ToString();


                //var favourite_route = (from person in context.Person
                //                       join ticket in context.TicketHistory
                //                         on person.PersonId equals ticket.PersonId
                //                       join route in context.Routes
                //                         on ticket.RouteId equals route.RouteId
                //                       where person.PersonId == 2
                //                       group person by new
                //                       {
                //                           route.RouteId

                //                       } into routeGroup

                //                       let output = new
                //                       {
                //                           ruta_fav = routeGroup.Count(),
                //                           id = routeGroup.Key.RouteId
                //                       }

                //                       orderby output.ruta_fav descending
                //                       select output).ToList();

                //foreach (var route in favourite_route)
                //{
                //    Console.WriteLine($"{route.ruta_fav},{route.id}");
                //}

                var favourite_route = (from person in context.Person
                                       join ticket in context.TicketHistory
                                         on person.PersonId equals ticket.PersonId
                                       join route in context.Routes
                                         on ticket.RouteId equals route.RouteId
                                       where person.PersonId == 2
                                       select new
                                       {
                                           personId = person.PersonId,
                                           routeId = route.RouteId,
                                       }).GroupBy(r => r.routeId).Select(r =>r.Key).Count();

                this.FavouriteRoute_content.Text = favourite_route.ToString();

            }

            InitializeComponent();

        }

        private void minimize_Click(object sender, RoutedEventArgs e)
        {

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

        private void back_Click(object sender, RoutedEventArgs e)
        {
            CentralWindow obj = new CentralWindow(PersonId);
            obj.Top = this.Top;
            obj.Left = this.Left;
            obj.Width = this.Width;
            obj.Height = this.Height;

            obj.Show();
            this.Close();

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Path_Window path_win = new Path_Window();
            path_win.Show();
            //this.Visibility = Visibility.Hidden;
        }
    }
}
