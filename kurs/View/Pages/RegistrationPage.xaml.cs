using kurs.AppData;
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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var v = AppData.ModelHelper.user23Entities.Client.Where(i => i.login == txb.Text && i.password == txb4.Password).FirstOrDefault();
            if (v == null)
            {
                MessageBox.Show("Такого пользователя нет");
            }
            if (v != null)
            {
                MessageBox.Show("Пользователь создан");
                StartWindow start = new StartWindow();
                start.Show();
                
            }
            string log = "";
            if (string.IsNullOrWhiteSpace(txb.Text))
                log += "Введите логин\n";

            if (string.IsNullOrWhiteSpace(txb4.Password))
                log += "Введите пароль\n";

            if (string.IsNullOrWhiteSpace(txb5.Password))
                log += "Повторите пароль\n";


            if (log != "")
            {
                MessageBox.Show(log);
                log = "";
                return;
            }
            Model.Client client = new Model.Client()
            {
                login = txb.Text,
                password = txb4.Password
                //Email = EmTb.Text
            };
            ModelHelper.user23Entities.Client.Add(client);
            ModelHelper.user23Entities.SaveChanges();
            MessageBox.Show("Учетная запись создана");
            txb.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
