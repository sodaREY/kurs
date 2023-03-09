using kurs.View.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kurs.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Log_Click_1(object sender, RoutedEventArgs e)
        {
            var v = AppData.ModelHelper.user23Entities.Client.Where(i => i.login == txb.Text && i.password == txb1.Password).FirstOrDefault();
            if (v == null)
            {
                MessageBox.Show("Такого пользователя нет");
            }
            if (v != null)
            {
                MessageBox.Show("Добро пожаловать");
                StartWindow start = new StartWindow();
                start.Show();
               
            }
            string log = "";
            if (string.IsNullOrWhiteSpace(txb.Text))
                log += "Введите логин\n";

            if (string.IsNullOrWhiteSpace(txb1.Password))
                log += "Введите пароль\n";

            //if (string.IsNullOrWhiteSpace(EmTb.Text))
            //    log += "Введите почту\n";


            if (log != "")
            {
                MessageBox.Show(log);
                log = "";
                return;
            }
            //Model.Profile profile = new Model.Profile()
            //{
            //    Login = LoginTB.Text,
            //    Password = PassTB.Password,
            //    Email = EmTb.Text
            //};
            //ModelHelper.entities1.Profile.Add(profile);
            //ModelHelper.entities1.SaveChanges();
            //MessageBox.Show("Учетная запись создана");
            //LoginTB.Text = "";

            //Profile profile1 = new Profile();
            //profile1.Show();
            //this.Close();
        }

        private void Back_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Reg_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
