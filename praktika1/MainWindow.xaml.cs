using Microsoft.SqlServer.Server;
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

namespace praktika1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool IsUsernameValid(string username)
        {
            // Проверка, что имя пользователя не пусто и не содержит русских символов
            if (string.IsNullOrWhiteSpace(username))
            {
                return false;
            }

            foreach (char c in username)
            {
                if (c >= 'А' && c <= 'я')
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsPasswordValid(string password)
        {
            // Проверка, что пароль не пустой
            return !string.IsNullOrWhiteSpace(password);
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            if (!IsUsernameValid(username))
            {
                MessageBox.Show("Введите корректное имя пользователя (без русских символов).");
                return;
            }

            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Введите корректный пароль.");
                return;
            }

            // Ваша логика регистрации пользователя

            MessageBox.Show("Пользователь успешно зарегистрирован.");

            // Очистка полей
            UsernameTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = LoginUsernameTextBox.Text.Trim();
            string password = LoginPasswordTextBox.Text.Trim();

            // Ваша логика авторизации пользователя

            MessageBox.Show("Пользователь успешно авторизован.");

            // Очистка полей
            LoginUsernameTextBox.Text = string.Empty;
            LoginPasswordTextBox.Text = string.Empty;

            {
                Window1 frm2 = new Window1();
                frm2.Show();
                this.Hide();
            }
        }


        private void ShowRegistration_Click(object sender, RoutedEventArgs e)
        {
            RegisterPanel.Visibility = Visibility.Visible;
        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
