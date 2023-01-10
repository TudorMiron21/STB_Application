using STB_App.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
//using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace STB_App
{
    /// <summary>
    /// Interaction logic for SubscriptionHistory.xaml
    /// </summary>
    public partial class SubscriptionHistory : Window
    {

        public int PersonId { get; set; }

        public SubscriptionHistory(int personId)
        {
            InitializeComponent();
            PersonId = personId;

            STB_appContext stb_AppContext = new STB_appContext();

            using (var context = new STB_appContext())
            {
                
                var subscriptions = (from person in context.Person
                               join subscription in context.SubscriptionHistory
                               on person.PersonId equals subscription.PersonId
                               join reference in context.RefRouteSubscription
                               on subscription.SubscriptionId equals reference.SubscriptionId
                               join route in context.Routes
                               on reference.RouteId equals route.RouteId
                               where person.PersonId == this.PersonId
                               select new
                               {
                                   Id = subscription.SubscriptionId,
                                   Route = route.RouteId,
                                   DateStart =subscription.DateStart,
                                   DateFinish = subscription.DateFinish,
                                  
                               });

        
                int idSubscription=subscriptions.First().Id;
                List<int> routes = new List<int>();
                string route_string="";
                foreach (var subscriprion in subscriptions)
                {

                    //history.Items.Add(new SubscriptionRow());
                    
                    if (idSubscription == subscriprion.Id)
                    {
                        route_string += subscriprion.Route.ToString() + " ";
                    }
                    else
                    {
                        SubscriptionRow row = new SubscriptionRow(subscriprion.Id,route_string, subscriprion.DateStart.ToString(), subscriprion.DateFinish.ToString());
                        history.Items.Add(row);
                        route_string = "";
                        
                        route_string += subscriprion.Route.ToString();
                    }
                    idSubscription = subscriprion.Id;

                }

            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {

            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(CentralWindow))
                    window.Visibility = Visibility.Visible;
            this.Close();
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void minimize_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}
