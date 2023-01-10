
using STB_App.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;



namespace STB_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }


        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, RoutedEventArgs e)
        {
            //minimizeaza fereastra
            this.WindowState = WindowState.Minimized;
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            STB_appContext STB_context = new STB_appContext();
            var useri = from u in STB_context.Person
                        select new
                        {
                            u.Passw,
                            u.UserName
                        };

            int flag = 0;
            foreach (var user in useri)
            {

                string utilizator = Username.Text;
                string pass = Password.Password;
                if (user.UserName == utilizator && user.Passw == pass)
                {
                    flag = 1;
                    CentralWindow objRegisterWindow = new CentralWindow(user.Passw);
                    objRegisterWindow.Left = this.Left;
                    objRegisterWindow.Top = this.Top;
                    objRegisterWindow.Width = this.Width;
                    objRegisterWindow.Height = this.Height;
                    objRegisterWindow.Show();

                    this.Close();
                }
            }

            

            if (flag == 0)
            {
                MessageBox.Show("Username sau parola gresita!");
            }

            //Animation.Visibility =  Visibility.Visible;

            //enable progress bar transition animation
            //progressBar.IsIndeterminate = true;
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow objRegisterWindow = new RegisterWindow();
            //this.Visibility = Visibility.Hidden;
            objRegisterWindow.Show();
        }

        private void login_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {

            Button copy = (Button)sender;

            copy.Width += 30;
            copy.Height += 5;
            copy.Margin = new Thickness(0, 30, 0, 0);
            this.UpdateLayout();

        }

        private void login_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {

            Button copy = (Button)sender;

            copy.Width -= 30;
            copy.Height -= 5;
            copy.Margin = new Thickness(0, 40, 0, 0);

            this.UpdateLayout();
        }

        private void register_MouseEnter(object sender, MouseEventArgs e)
        {
            Button copy = (Button)sender;

            copy.Width += 30;
            copy.Height += 5;
            copy.Margin = new Thickness(0, 5, 0, 0);
            this.UpdateLayout();
        }

        private void register_MouseLeave(object sender, MouseEventArgs e)
        {
            Button copy = (Button)sender;

            copy.Width -= 30;
            copy.Height -= 5;
            copy.Margin = new Thickness(0, 15, 0, 0);

            this.UpdateLayout();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //open a new window map
            Map objMap = new Map();
            objMap.Show();
        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
