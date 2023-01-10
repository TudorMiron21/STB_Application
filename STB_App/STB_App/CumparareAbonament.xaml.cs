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
    /// Interaction logic for CumparareAbonament.xaml
    /// </summary>
    public partial class CumparareAbonament : Window
    {
        public int PersonId { get; set; }
        public int nr_maxim_rute = 5;

        public CumparareAbonament()
        {
            InitializeComponent();
            PopulareComboBox();
        }

        public CumparareAbonament(int PersonId)
        {
            InitializeComponent();
            PopulareComboBox();
            this.PersonId = PersonId;
        }

        private void PopulareComboBox()
        {
            STB_appContext STB_context = new STB_appContext();

            var rute = from r in STB_context.Routes
                       select new
                       {
                           r.RouteId
                       };

            foreach (var item in rute)
            {
                cbRuteCumparareAbonament.Items.Add(item.RouteId.ToString());
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

        private bool Verificare_existenta_abonament(DateTime data_selectata, DateTime data_terminare_abonament)
        {
            STB_appContext STB_context = new STB_appContext();
            var data_finalizare_abonamente = from abonamente in STB_context.SubscriptionHistory
                                             where abonamente.PersonId == this.PersonId
                                             select new
                                             {
                                                 abonamente.DateStart,
                                                 abonamente.DateFinish
                                             };


            foreach (var item in data_finalizare_abonamente)
            {
                if (item.DateStart <= data_selectata && data_selectata <= item.DateFinish || item.DateStart <= data_terminare_abonament && data_terminare_abonament <= item.DateFinish)
                    return true;
            }

            return false;
        }

        private void plateste_abonament_Click(object sender, RoutedEventArgs e)
        {
            if (nr_maxim_rute == 5)
            {
                MessageBox.Show("Trebuie sa selectati minim o ruta pentru a va cumpara abonament");
                return;
            }

            STB_appContext STB_context = new STB_appContext();
            var card = (from c in STB_context.CardDetails
                        where c.PersoanaId == PersonId
                        select c.NumarCard).ToList();

            if (card.Count() == 0)
            {
                MessageBox.Show("Trebuie sa va adaugati un card pentru a putea cumpara abonamente");
            }
            else
            {
                if (!calendar.SelectedDate.HasValue)
                {
                    MessageBox.Show("Trebuie sa selectati data la care sa inceapa abonamentul");
                    return;
                }

                DateTime data_incepere_abonament = calendar.SelectedDate.Value;

                if(data_incepere_abonament<DateTime.Now)
                {
                    MessageBox.Show("Nu puteti selecta o data din trecut");
                    return;
                }

                DateTime data_sfarsire_abonment = data_incepere_abonament.AddMonths(1);


                if (Verificare_existenta_abonament(data_incepere_abonament, data_sfarsire_abonment) == false)
                {
                    float price = 20 * cbRuteAdaugate.Items.Count;

                    var categorie_persoana = (from pers in STB_context.Person
                                                 join cat in STB_context.Category on pers.CategoryId equals cat.CategoryId
                                                 where pers.PersonId == this.PersonId
                                                 select cat.PersonType).ToList();
                    string tipe_persoana = categorie_persoana[0].ToString();

                    switch (tipe_persoana)
                    {
                        case "Student":
                            price = price - price * 1 / 4;
                            break;
                        case "Elev":
                            price = price - price * 2 / 4;
                            break;
                        case "Copil":
                            price = 0;
                            break;
                        case "Pensionr":
                            price = price - price * 3 / 4;
                            break;
                    }

                    Models.SubscriptionHistory abonament = new Models.SubscriptionHistory
                    {
                        PersonId = this.PersonId,
                        DateStart = data_incepere_abonament,
                        DateFinish = data_sfarsire_abonment,
                        Price = (int)price
                    };

                    STB_context.SubscriptionHistory.Add(abonament);
                    STB_context.SaveChanges();

                    int id_abonament = STB_context.SubscriptionHistory.OrderByDescending(x => x.SubscriptionId).FirstOrDefault().SubscriptionId;
                    

                    for(int i=0;i<cbRuteAdaugate.Items.Count;i++)
                    {
                        RefRouteSubscription rute_din_abonament = new RefRouteSubscription();
                        rute_din_abonament.SubscriptionId = id_abonament;
                        rute_din_abonament.RouteId = int.Parse(cbRuteAdaugate.Items[i].ToString());
                        STB_context.RefRouteSubscription.Add(rute_din_abonament);
                        STB_context.SaveChanges();
                    }

                    
                    cbRuteAdaugate.Items.Clear();
                    cbRuteCumparareAbonament.Items.Clear();

                    PopulareComboBox();
                    nr_maxim_rute = 5;

                    MessageBox.Show("Abonament cumparat cu succes");
                }
                else
                {
                    MessageBox.Show("Aveti deja un abonament valid in perioada selectata");
                }
            }
        }

        private void adauga_ruta_Click(object sender, RoutedEventArgs e)
        {
            if (nr_maxim_rute == 0)
            {
                MessageBox.Show("A-ti selectat numarul maxim de rute pentru un abonament");
            }
            else
            {
                if(cbRuteCumparareAbonament.SelectedItem==null)
                {
                    MessageBox.Show("Trebuie sa selectati o ruta pentru a avea ce sa adaugati");
                    return;
                }
                cbRuteAdaugate.Items.Add(cbRuteCumparareAbonament.SelectedItem.ToString());

                cbRuteCumparareAbonament.Items.RemoveAt(cbRuteCumparareAbonament.SelectedIndex);

                nr_maxim_rute--;
            }
        }

        private void elimina_ruta_Click(object sender, RoutedEventArgs e)
        {
            if (nr_maxim_rute == 5)
            {
                MessageBox.Show("Nu aveti nici o ruta adaugata pentru a putea elimina");
            }
            else
            {
                if (cbRuteAdaugate.SelectedItem == null)
                {
                    MessageBox.Show("Trebuie sa selectati o ruta pentru a avea ce elimina");
                    return;
                }
                cbRuteCumparareAbonament.Items.Add(cbRuteAdaugate.SelectedItem.ToString());

                cbRuteAdaugate.Items.RemoveAt(cbRuteAdaugate.SelectedIndex);

                nr_maxim_rute++;
            }
        }
    }
}
