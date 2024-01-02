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
        public ObservableCollection<Teachers> Teacher { get; set; }
        public Teachers()
        {
            InitializeComponent();
        }

        private void btn_teachers_Click(object sender, RoutedEventArgs e)
        {
            using(var context = new AthenaModule())
            {
                
            }
        }
    }
}
