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
    }
}
