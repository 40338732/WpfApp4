using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WpfApp4.Database;
using WpfApp4.Models;
using System.Collections.ObjectModel;


namespace WpfApp4.ViewModels
{
    public class ViewOrderViewModel : BaseViewModel
    {
        public ObservableCollection<Order> Orders { get; set; }

        public ViewOrderViewModel()
        {
            LoadFromFile load = new LoadFromFile();

            if(!load.FromCsv())
            {
                Orders = new ObservableCollection<Order>();

            }
            else
            {
                Orders = new ObservableCollection<Order>(load.Orders);
            }
        }
    }
}
