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
    public partial class InsertGroup : Window
    {
        public InsertGroup()
        {
            InitializeComponent();
        }

        private void addProf1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNameGroup.Text)) { MessageBox.Show("Introduceti numele grupei!!!","Eroare",MessageBoxButton.OK,MessageBoxImage.Warning); }
            if (string.IsNullOrEmpty(txtYear.Text)) { MessageBox.Show("Introduceti anul de invatamant al grupei!!!","Eroare",MessageBoxButton.OK,MessageBoxImage.Warning); }
            AdaugaGrupe();
            MessageBox.Show("A fost adaugat grupa cu succes","Succes",MessageBoxButton.OK,MessageBoxImage.Information);

        }

        public void AdaugaGrupe()
        {
            try
            {
                using (var context = new AthenaModel())
                {
                    var adaugGroup = new grupe
                    {
                        nume_grupa = txtNameGroup.Text,
                        is_active = true,
                        anul = Convert.ToInt32(txtYear.Text)
                        
                    };
                    context.grupe.Add(adaugGroup);
                    context.SaveChanges();
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
