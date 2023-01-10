using MaterialDesignThemes.Wpf;
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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;
using System.Management.Instrumentation;
using System.IdentityModel.Tokens;

namespace STB_App
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    /// 
    
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
            
            
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

        private void register_Click(object sender, RoutedEventArgs e)
        {

            STB_appContext CategoryID = new STB_appContext();

            // Select the category ID
            var category = from c in CategoryID.Category
                           where c.PersonType == Category.Text
                           select c.CategoryId;

            // Check that all fields are completed
            if (string.IsNullOrEmpty(Nume.Text) ||
                string.IsNullOrEmpty(Prenume.Text) ||
                string.IsNullOrEmpty(Email.Text) ||
                string.IsNullOrEmpty(Username.Text) ||
                string.IsNullOrEmpty(Password.Password) ||
                string.IsNullOrEmpty(Telefon.Text) ||
                string.IsNullOrEmpty(Category.Text))
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            // Check that password has at least 8 characters
            if (Password.Password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.");
                return;
            }

            // Check that phone number has exactly 10 digits
            if (Telefon.Text.Length != 10)
            {
                MessageBox.Show("Phone number must have exactly 10 digits.");
                return;
            }

            // Insert data into database
            STB_appContext STB_context = new STB_appContext();
            Person person = new Person();
            person.FirstName = Nume.Text;
            person.SecondName = Prenume.Text;
            person.Email = Email.Text;
            person.Passw = Password.Password;
            person.PhoneNumber = Telefon.Text;
            person.UserName = Username.Text;

            // Set the category ID
            person.CategoryId = category.First();
            STB_context.Person.Add(person);
            STB_context.SaveChanges();

            MessageBox.Show("Account created successfully!");
            this.Close();
        }

    

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {
            register.IsEnabled = true;
            userError.Visibility = Visibility.Hidden;
            STB_appContext STB_context = new STB_appContext();
            
            var useri = from u in STB_context.Person
                        select new
                        {
                            u.UserName
                        };

            foreach (var user in useri)
            {
                string utilizator = Username.Text;
                if (user.UserName == utilizator )
                {
                    userError.Visibility = Visibility.Visible;
                    register.IsEnabled = false;
                }
            }

           
        }

        private void Password_changed(object sender, RoutedEventArgs args)
        {
            register.IsEnabled = true;
            passError.Visibility = Visibility.Hidden;
            if (Password.Password.ToString().Length < 8)
            {
                passError.Visibility = Visibility.Visible;
                register.IsEnabled = false;
            }
         
        }

        private void Nume_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
        }

        private void Telefon_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {
         
        }
        
    }
}
