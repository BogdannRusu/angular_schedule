using Athena_Solution.DataModel;
using Athena_Solution.Views;
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

namespace Athena_Solution.Pages
{
    /// <summary>
    /// Interaction logic for Groups.xaml
    /// </summary>
    public partial class Groups : UserControl
    {
        private AthenaModel context;
        public Groups()
        {
            InitializeComponent();
            context = new AthenaModel();
            dataGridGroups.ItemsSource = context.grupe.ToList();
        }

        private void buttonAddGroup_Click(object sender, RoutedEventArgs e)
        {
            var insertGroup = new InsertGroup();
            insertGroup.ShowDialog();
        }

        private void buttonRefreshGroup_Click(object sender, RoutedEventArgs e)
        {
            context = new AthenaModel();
            dataGridGroups.ItemsSource = context.grupe.ToList();
        }

        private void buttonDeleteGroup_Click(object sender, RoutedEventArgs e)
        {
            var delGroup = txtIdGroup.Text;
            if (int.TryParse(delGroup, out int groupIdToDelete))
            {
                DeleteGroups(groupIdToDelete);
            }
            else
            {
                MessageBox.Show("ID grupa inexistent. Va rugam sa introduceti ID corect", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            MessageBox.Show("A fost sters grupa cu succes", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void DeleteGroups(int idGroup)
        {
            var deleteGroup = context.grupe.FirstOrDefault(t => t.id_grupa == idGroup);
            var adminUser = context.users.FirstOrDefault(t => t.user_id == 1002);

            if (adminUser != null)
            {
                if (deleteGroup != null)
                {
                    context.grupe.Remove(deleteGroup);
                    context.SaveChanges();
                }
                else { MessageBox.Show("Grupa cu ID dat nu a fost gasita!!", "Eroare", MessageBoxButton.OK, MessageBoxImage.Exclamation); }
            }
            else { MessageBox.Show("Nu aveti drepturi de administrator", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error); }
        }
    }
}
