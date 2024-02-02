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
    /// Interaction logic for Cabinet.xaml
    /// </summary>
    public partial class Cabinet : UserControl
    {
        private AthenaModel context;
        public Cabinet()
        {
            InitializeComponent();
            context = new AthenaModel();
            dataGridCabinet.ItemsSource = context.cabinete.ToList();
        }

        private void buttonRefreshCabinet_Click(object sender, RoutedEventArgs e)
        {
            context = new AthenaModel();
            dataGridCabinet.ItemsSource = context.cabinete.ToList();
        }

        private void buttonAddGroup_Click(object sender, RoutedEventArgs e)
        {
            var delCab = txtIdCab.Text;
            if (int.TryParse(delCab, out int cabIdToDelete))
            {
                DeleteCabinet(cabIdToDelete);
            }
            else
            {
                MessageBox.Show("ID cabinet inexistent. Va rugam sa introduceti ID corect", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            MessageBox.Show("A fost sters cabinetul cu succes", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public void DeleteCabinet(int idCab)
        {
            var deleteCab = context.cabinete.FirstOrDefault(t => t.id_cabinet == idCab);
            var adminUser = context.users.FirstOrDefault(t => t.user_id == 1002);

            if (adminUser != null)
            {
                if (deleteCab != null)
                {
                    context.cabinete.Remove(deleteCab);
                    context.SaveChanges();
                }
                else { MessageBox.Show("Cabientul cu ID dat nu a fost gasita!!", "Eroare", MessageBoxButton.OK, MessageBoxImage.Exclamation); }
            }
            else { MessageBox.Show("Nu aveti drepturi de administrator", "Eroare", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            InsertCabiet cabinet = new InsertCabiet();
            cabinet.Show();
        }
    }
}
