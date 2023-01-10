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
using STB_App.Models;
using MessageBox = System.Windows.Forms.MessageBox;

namespace STB_App
{
    /// <summary>
    /// Interaction logic for CumparareBilet.xaml
    /// </summary>
     

    public partial class CumparareBilet : Window
    {
        public int PersonId { get; set; }
        public CumparareBilet()
        {
            InitializeComponent();
            AdaugareRute();
        }

        public CumparareBilet(int PersonId)
        {
            this.PersonId = PersonId;
            InitializeComponent();
            AdaugareRute();
        }

        private void AdaugareRute()
        {
            STB_appContext STB_context = new STB_appContext();

            var rute = from r in STB_context.Routes
                       select new
                       {
                           r.RouteId
                       };

            foreach(var item in rute)
            {
                cbRuteCumparareBilet.Items.Add(item.RouteId.ToString());
            }    
        }

        private void plateste_bilet_Click(object sender, RoutedEventArgs e)
        {
            STB_appContext STB_context = new STB_appContext();


            var card = (from c in STB_context.CardDetails
                       where c.PersoanaId == PersonId
                       select c.NumarCard).ToList();

            if(card.Count() == 0)
            {
                MessageBox.Show("Trebuie sa va adaugati un card pentru a putea cumpara bilete");
            }
            else
            {
                if(cbRuteCumparareBilet.SelectedItem==null)
                {
                    MessageBox.Show("Trebuie sa selectti o ruta pentru a putea cumpara biletul");
                    return;
                }
                int idRuta = int.Parse((cbRuteCumparareBilet.SelectedItem.ToString()));
                TicketHistory bilet = new TicketHistory();
                bilet.RouteId = idRuta;
                bilet.PersonId = this.PersonId;

                STB_context.TicketHistory.Add(bilet);
                STB_context.SaveChanges();

                MessageBox.Show("Bilet cumparat cu succes");
            }
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

        private void inapoi_Click(object sender, RoutedEventArgs e)
        {
            CentralWindow objCentralWindow = new CentralWindow(this.PersonId);
            this.Visibility = Visibility.Hidden;
            objCentralWindow.Show();
        }

    }
}
