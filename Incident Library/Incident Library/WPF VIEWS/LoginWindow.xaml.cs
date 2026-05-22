using System.Windows;
using System.Windows.Input;

namespace Incident_Library.WPF_VIEWS
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            AttemptLogin();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                AttemptLogin();
        }

        private void AttemptLogin()
        {
            string username = txtUsername.Text.Trim();
            string password = pwdPassword.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                txtError.Text = "Please enter both username and password.";
                txtError.Visibility = Visibility.Visible;
                return;
            }

            // Vi skal udskifte med rigtig authentication via LoginViewModel / IUserReposirtory

            if (username == "admin" && password == "admin")
            {
                var home = new HomePageWindow__Shell_();
                home.Show();
                this.Close();
            }
            else
            {
                txtError.Text = "Invalid username or password.";
                txtError.Visibility = Visibility.Visible;
                pwdPassword.Clear();
                pwdPassword.Focus();
            }
        }
    }
}