using Athena_Solution.DataModel;
using Athena_Solution.DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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

namespace Athena_Solution.Pages
{
    /// <summary>
    /// Interaction logic for Teachers.xaml
    /// </summary>
    public partial class Teachers : UserControl
    {
        private AthenaModule context;
        public Teachers()
        {
            InitializeComponent();
            context = new AthenaModule();
            DataTeachers.ItemsSource = context.profesori.ToList();
        }

        private void del_teachers_Click(object sender, RoutedEventArgs e)
        {
            var delProf = txtDelProf.Text;
            if (int.TryParse(delProf, out int teacherIdToDelete))
            {
                DeleteTeachers(teacherIdToDelete);
            }
            else
            {
                MessageBox.Show("Invalid Teacher ID format. Please enter a valid integer.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void DeleteTeachers(int IdProf)
        {
            var deleteProf = context.profesori.FirstOrDefault(t => t.id_prof == IdProf);
            var adminUser = context.users.FirstOrDefault(t => t.user_id == 1002);

            if (adminUser != null)
            {
                if(deleteProf != null)
                {
                    context.profesori.Remove(deleteProf);
                    context.SaveChanges();
                }
                else { MessageBox.Show("Profesorul cu ID dat nu a fost gasit!!", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation); }
            }
            else { MessageBox.Show("Nu aveti drepturi de administrator","Eroare",MessageBoxButton.OK,MessageBoxImage.Error); }
        }
    }
}
