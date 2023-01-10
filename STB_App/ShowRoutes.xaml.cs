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
    /// Interaction logic for ShowRoutes.xaml
    /// </summary>
    public partial class ShowRoutes : Window
    {
        public ShowRoutes()
        {
            InitializeComponent();
            DataGridRute.AutoGenerateColumns = true;
            DataGridRute.ColumnWidth = DataGridLength.Auto;
            //DataGridRute.ItemsSource = functie de aducere rute
            

            var context = new STB_appContext();

            var rute = from r in context.Routes
                       join rs in context.RefStationRoute on r.RouteId equals rs.RouteId
                       join s in context.Stations on rs.StationId equals s.StationId
                       select new
                       {
                           r.RouteId,
                           s.StationName
                       };

            if (rute != null)
            {
                DataGridRute.ItemsSource = rute.ToList();
            }

        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            CentralWindow centralWindow = new CentralWindow();
            centralWindow.Top = this.Top;
            centralWindow.Left = this.Left;
            centralWindow.Width = this.Width;
            centralWindow.Height = this.Height;

            centralWindow.Show();

            this.Close();
        }

     
    }
}
