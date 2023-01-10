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

                if (subscriptions.Any())
                {
                    int idSubscription = subscriptions.First().Id;
                    int Verify = subscriptions.Count();
                    List<int> routes = new List<int>();
                    string route_string = "";
                    int counter = 0;

                    foreach (var subscriprion in subscriptions)
                    {

                        //history.Items.Add(new SubscriptionRow());

                        if (idSubscription == subscriprion.Id)
                        {
                            route_string += subscriprion.Route.ToString() + "/";
                        }
                        else
                        {
                            SubscriptionRow Subscription = new SubscriptionRow(subscriprion.Id, route_string, subscriprion.DateStart.ToString(), subscriprion.DateFinish.ToString());
                            history.Items.Add(Subscription);
                            route_string = "";
                            idSubscription = subscriprion.Id;
                            route_string += subscriprion.Route.ToString();
                        }

                        if (counter ==Verify-1)
                        {
                            SubscriptionRow Subscription = new SubscriptionRow(subscriprion.Id, route_string, subscriprion.DateStart.ToString(), subscriprion.DateFinish.ToString());
                            history.Items.Add(Subscription);
                        }
                        counter++;
                  
                    }

                }
                else
                {
                    //show a message Box
                    MessageBox.Show("Nu exista abonamente pentru acest utilizator");

                }

            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {

            CentralWindow objCentralWindow = new CentralWindow(PersonId);

            objCentralWindow.Top = this.Top;
            objCentralWindow.Left = this.Left;
            objCentralWindow.Width = this.Width;
            objCentralWindow.Height = this.Height;

            objCentralWindow.Show();

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
