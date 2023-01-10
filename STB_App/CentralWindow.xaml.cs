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

        public CentralWindow(int PersonId) : this()
        {
            this.PersonId = PersonId;
            InitializeComponent();
        }

        private void buy_ticket_Click(object sender, RoutedEventArgs e)
        {
            CumparareBilet objCumparareBilet = new CumparareBilet(this.PersonId);
            objCumparareBilet.Top = this.Top;
            objCumparareBilet.Left = this.Left;
            objCumparareBilet.Width = this.Width;
            objCumparareBilet.Height = this.Height;

            objCumparareBilet.Show();
            this.Close();
        }

        private void buy_subscription_Click(object sender, RoutedEventArgs e)
        {
            CumparareAbonament objCumparareAbonament = new CumparareAbonament(this.PersonId);
            objCumparareAbonament.Top = this.Top;
            objCumparareAbonament.Left = this.Left;
            objCumparareAbonament.Width = this.Width;
            objCumparareAbonament.Height = this.Height;

            objCumparareAbonament.Show();
            this.Close();
        }

        private void ticket_history_Click(object sender, RoutedEventArgs e)
        {
            TicketHistoy objIstoricBilete = new TicketHistoy(this.PersonId);
            objIstoricBilete.Top = this.Top;
            objIstoricBilete.Left = this.Left;
            objIstoricBilete.Width = this.Width;
            objIstoricBilete.Height = this.Height;

            objIstoricBilete.Show();
            this.Close();

        }

        private void subscription_history_Click(object sender, RoutedEventArgs e)
        {
            SubscriptionHistory objIstoricAbonamente = new SubscriptionHistory(this.PersonId);
            objIstoricAbonamente.Top = this.Top;
            objIstoricAbonamente.Left = this.Left;
            objIstoricAbonamente.Width = this.Width;
            objIstoricAbonamente.Height = this.Height;

            objIstoricAbonamente.Show();
            this.Close();
        }

        private void my_profile_Click(object sender, RoutedEventArgs e)
        {
            MyProfile objMyProfile = new MyProfile(this.PersonId);

            objMyProfile.Top = this.Top;
            objMyProfile.Left = this.Left;
            objMyProfile.Width = this.Width;
            objMyProfile.Height = this.Height;
            
            objMyProfile.Show();

            this.Close();
        }

        private void insert_card_Click(object sender, RoutedEventArgs e)
        {
            AdaugareCard adaugareCard = new AdaugareCard(this.PersonId);
            adaugareCard.Top = this.Top;
            adaugareCard.Left = this.Left;
            adaugareCard.Width = this.Width;
            adaugareCard.Height = this.Height;

            adaugareCard.Show();
            this.Close();
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
