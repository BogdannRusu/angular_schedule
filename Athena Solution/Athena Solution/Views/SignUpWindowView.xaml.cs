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
    /// Interaction logic for SignUpWindowView.xaml
    /// </summary>
    public partial class SignUpWindowView : Window
    {
        AthenaModule cotext = new AthenaModule();
        public SignUpWindowView()
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

        private void exitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void SignUp()
        {
            var username = txtUsername.Text;
            var password = txtPassword;
            using(var context = new AthenaModule())
            {
                var newUser = new users
                {
                    name = username,
                    password = EncryptPassword(password.Password.ToString()),
                    email = "test@gmail.com",
                    is_active = 1
                };

                    context.users.Add(newUser);
                    context.SaveChanges();
                    MessageBox.Show("A fost introdus utilizatorul cu succes!", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);

                    Hide();
                    var login = new LoginWindowView();
                    login.ShowDialog();
                   
                
                
            }
        }

        public static string EncryptPassword(string pass)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(pass));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void signupBtn_Click(object sender, RoutedEventArgs e)
        {
            SignUp();
        }
    }
}
