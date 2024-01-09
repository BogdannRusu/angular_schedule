using Athena_Solution.DataModel;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Athena_Solution
{
    /// <summary>
    /// Interaction logic for LoginWindowView.xaml
    /// </summary>
    public partial class LoginWindowView : Window
    {
        AthenaModel context = new AthenaModel();
        public LoginWindowView()
        {
            InitializeComponent();
        }

        //Coudl la Tematica Dark ========================>
        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();
        //===================================>

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            //Codul la tema ========================>
            ITheme theme = paletteHelper.GetTheme();
            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }

            paletteHelper.SetTheme(theme);
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "1")
            {
                Hide();
                var signUp = new SignUpWindowView();
                signUp.Show();
            }
            else
            {
                var username = txtUsername.Text.ToString();
                var password = txtPassword.Password.ToString();


                if (VerifyUser(username, password))
                {
                    ShowMainView();
                    Hide();
                }
                else
                {
                    ShowErrorMessage("Datele introduse nu coincid");
                }
            }

        }

        //Verify user if exist in database
        private void ShowMainView()
        {
            var mainView = new MainWindow();
            mainView.Show();
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public bool VerifyUser(string enteredUserName, string enteredPassword)
        {
            var user = context.users.FirstOrDefault(u => u.name == enteredUserName);
            if (user != null)
            {
                string hashedPassword = EncryptPassword(enteredPassword);
                return user.password == hashedPassword;
            }
            
                return false;
        }

        private string EncryptPassword(string pass)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pass));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void exitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
