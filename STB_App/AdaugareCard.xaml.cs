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
using STB_App.Models2;
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
            CentralWindow objCentralWindow = new CentralWindow(PersonId);

            objCentralWindow.Top = this.Top;
            objCentralWindow.Left = this.Left;
            objCentralWindow.Width = this.Width;
            objCentralWindow.Height = this.Height;

            objCentralWindow.Show();

            this.Close();

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


            if (card.NumarCard.Length != 16)
            {
                MessageBox.Show("Numarul cardului trebuie sa aiba 16 cifre");
                return;
            }

            if (card.DataExpirare.Length != 5)
            {
                MessageBox.Show("Data de expirare trebuie sa aiba formatul MM/YY");
                return;
            }

            if (card.Cvv.Length != 3)
            {
                MessageBox.Show("CVV-ul trebuie sa aiba 3 cifre");
                return;
            }

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
