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
    public partial class InsertTeachers : Window
    {
        public InsertTeachers()
        {
            InitializeComponent();
        }

        private void addProf1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)) { MessageBox.Show("Introduceti numele profesorului!!!","Eroare",MessageBoxButton.OK,MessageBoxImage.Warning); }
            if (string.IsNullOrEmpty(txtLastName.Text)) { MessageBox.Show("Introduceti prenumele profesorului!!!","Eroare",MessageBoxButton.OK,MessageBoxImage.Warning); }
            if (string.IsNullOrEmpty(datePickerStartDate.Text)) { MessageBox.Show("Introduceti data activarii profesorului!!!","Eroare",MessageBoxButton.OK,MessageBoxImage.Warning); }
            AdaugaProfesor();
            MessageBox.Show("A fost adaugat profesorul cu succes","Succes",MessageBoxButton.OK,MessageBoxImage.Information);

        }

        public void AdaugaProfesor()
        {
            try
            {
                using (var context = new AthenaModel())
                {
                    var adaugprof = new profesori
                    {
                        nume = txtName.Text,
                        prenume = txtLastName.Text,
                        patronimic = txtPatronimic.Text,
                        data_activarii = datePickerStartDate.DisplayDate,
                        end_data_activarii = datePickerEndActiv.DisplayDate,
                        functia = txtProfesie.Text,
                        is_active = true
                    
                    };
                    context.profesori.Add(adaugprof);
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
