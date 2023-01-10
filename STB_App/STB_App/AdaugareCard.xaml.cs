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
    /// Interaction logic for AdaugareCard.xaml
    /// </summary>
    public partial class AdaugareCard : Window
    {
        public int PersonId { get; set; }
        public AdaugareCard()
        {
            InitializeComponent();
        }

        public AdaugareCard(int PersonId)
        {
            InitializeComponent();
            this.PersonId = PersonId;
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

        private void salveaza_card_Click(object sender, RoutedEventArgs e)
        {
            STB_appContext STB_context = new STB_appContext();

            string numar_card = NumarCard.Text;
            string data_expirare = DataExpirare.Text;
            string CVV_card = CVV.Text;

            var numar_card_existent = from c in STB_context.CardDetails
                                      where c.PersoanaId == this.PersonId
                                      select c.NumarCard;

            foreach(var item in numar_card_existent)
            {
                if(item.ToString()==numar_card)
                {
                    MessageBox.Show("Acest card este deja adaugat");
                    return;
                }
            }

            CardDetails card = new CardDetails
            {
                PersoanaId = this.PersonId,
                NumarCard = numar_card,
                DataExpirare = data_expirare,
                Cvv = CVV_card
            };

            
            STB_context.CardDetails.Add(card);
            STB_context.SaveChanges();

            NumarCard.Clear();
            DataExpirare.Clear();
            CVV.Clear();

            MessageBox.Show("Card adaugat cu succes");
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !char.IsDigit(e.Text, e.Text.Length - 1);
        }
    }
}
