using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Athena_Solution.Model;

namespace Athena_Solution.ViewModel
{
    class OrderVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public DateTime DisplayOrderDate
        {
            get { return _pageModel.OrderDate; }
            set { _pageModel.OrderDate = value; OnPropertyChanged(); }
        }

        public OrderVM()
        {
            _pageModel = new PageModel();
            DisplayOrderDate = DateTime.Now;
        }
    }
}
