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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace STB_App
{
    /// <summary>
    /// Interaction logic for TicketHistoy.xaml
    /// </summary>
    public partial class TicketHistoy : Window
    {
        public int PersonId { get; set; }
        //public List<TicketRow> ticketRows { get; set; }
        public TicketHistoy(int personId)
        {
            InitializeComponent();    
            PersonId = personId;
            //this.ticketRows = new List<TicketRow>();
            using (var context = new STB_appContext())
            {

                var tickets = (from person in context.Person
                               join ticket in context.TicketHistory
                               on person.PersonId equals ticket.PersonId
                               where person.PersonId == this.PersonId
                               select new
                               {
                                   CalatorieId = ticket.TicketId,
                                   routeId = ticket.RouteId,
                                   data = ticket.DataBilet
                               }) ;

                foreach(var ticket in tickets)
                {
                    string data = ticket.data.ToString();
                    history.Items.Add(new TicketRow(ticket.CalatorieId,ticket.routeId,data));
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

        private void history_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
