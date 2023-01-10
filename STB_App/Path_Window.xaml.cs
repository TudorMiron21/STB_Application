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
    /// Interaction logic for Path_Window.xaml
    /// </summary>
    public partial class Path_Window : Window
    {
        public Path_Window()
        {
            InitializeComponent();
        }

        private void minimize_Click(object sender, RoutedEventArgs e)
        {

        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {

            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MyProfile))
                {
                    MyProfile new_win = (MyProfile)window;
                    window.Close();

                    var imgUri = new Uri(this.path.Text);
                    new_win.myImage.ImageSource = new BitmapImage(imgUri);

                    new_win.Show();
                   
                }
            this.Visibility = Visibility.Hidden;
        }

        private void previous_Click(object sender, RoutedEventArgs e)
        {

            foreach (Window window in Application.Current.Windows)
                if (window.GetType() == typeof(MyProfile))
                    window.Visibility = Visibility.Visible;
            else
                if(window.GetType() == typeof(Path_Window))
                    window.Visibility = Visibility.Hidden;
        }

        private void save_MouseEnter(object sender, MouseEventArgs e)
        {
            Button copy = (Button)sender;

            copy.Width += 30;
            copy.Height += 5;
            copy.Margin = new Thickness(0, 30, 0, 0);
            this.UpdateLayout();
        }

        private void save_MouseLeave(object sender, MouseEventArgs e)
        {
            Button copy = (Button)sender;

            copy.Width -= 30;
            copy.Height -= 5;
            copy.Margin = new Thickness(0, 40, 0, 0);

            this.UpdateLayout();
        }

        private void previous_MouseEnter(object sender, MouseEventArgs e)
        {

            //Button copy = (Button)sender;

            //copy.Width += 30;
            //copy.Height += 5;
            //copy.Margin = new Thickness(0, 30, 0, 0);
            //this.UpdateLayout();

        }

        private void previous_MouseLeave(object sender, MouseEventArgs e)
        {
            //Button copy = (Button)sender;

            //copy.Width -= 30;
            //copy.Height -= 5;
            //copy.Margin = new Thickness(0, 40, 0, 0);

            //this.UpdateLayout();
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
