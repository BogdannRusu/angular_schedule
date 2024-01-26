using Athena_Solution.DataModel;
using Athena_Solution.DTO;
using Athena_Solution.Views;
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
        private AthenaModel context;
        public Teachers()
        {
            InitializeComponent();
            context = new AthenaModel();
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
                MessageBox.Show("ID Profesor inexistent. Va rugam sa introduceti ID corect", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            MessageBox.Show("A fost sters profesorul cu succes", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        public void DeleteTeachers(int IdProf)
        {
            var deleteProf = context.profesori.FirstOrDefault(t => t.id_prof == IdProf);
            var adminUser = context.users.FirstOrDefault(t => t.user_id == 1002);

            if (adminUser != null)
            {
                if (deleteProf != null)
                {
                    context.profesori.Remove(deleteProf);
                    context.SaveChanges();
                }
                else { MessageBox.Show("Profesorul cu ID dat nu a fost gasit!!", "Eroare", MessageBoxButton.OK, MessageBoxImage.Exclamation); }
            }
            else { MessageBox.Show("Nu aveti drepturi de administrator", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        public void UpdateTeachers()
        {
            context = new AthenaModel();
            DataTeachers.ItemsSource = context.profesori.ToList();

        }

        private void add_teachers_Click(object sender, RoutedEventArgs e)
        {
            var insertTeacher = new InsertTeachers();
            insertTeacher.ShowDialog();
        }

        private void update_Teacher_Click(object sender, RoutedEventArgs e)
        {
            UpdateTeachers();
        }
    }
}
