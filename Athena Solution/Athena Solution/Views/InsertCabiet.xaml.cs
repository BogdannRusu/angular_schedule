using Athena_Solution.DataModel;
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
using System.Windows.Shapes;

namespace Athena_Solution.Views
{
    /// <summary>
    /// Interaction logic for InsertTeachers.xaml
    /// </summary>
    public partial class InsertCabiet : Window
    {
        public InsertCabiet()
        {
            InitializeComponent();
        }

        public void AdaugaCabinet()
        {
            try
            {
                using (var context = new AthenaModel())
                {
                    var adaugCab = new cabinete
                    {
                        nr_cabinet = Convert.ToInt32(txtNrCabinet.Text),
                        is_active = true,
                        
                    };
                    context.cabinete.Add(adaugCab);
                    context.SaveChanges();
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void addCabinet_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNrCabinet.Text)) { MessageBox.Show("Introduceti nr Cabinetului!!!", "Eroare", MessageBoxButton.OK, MessageBoxImage.Warning); }
            AdaugaCabinet();
            MessageBox.Show("A fost adaugat cabinetul cu succes", "Succes", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
