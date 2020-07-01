using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Add for project
using WpfApp4.Commands;
using System.Windows.Input;
using WpfApp4.Views;
using System.Windows.Controls;

namespace WpfApp4.ViewModels
{
    class MainWIndowViewModel : BaseViewModel
    {
        public string AddOrderButtonContent { get; private set; }
        public string ViewOrderButtonContent { get; private set; }

        public ICommand AddOrderButtonCommand { get; private set; }
        public ICommand ViewOrderButtonCommand { get; private set; }

        public UserControl ContentControlBinding { get; private set; }
        public MainWIndowViewModel()
        {
            AddOrderButtonContent = "Add Order";
            ViewOrderButtonContent = "View Orders";

            AddOrderButtonCommand = new RelayCommand(AddOrderButtonClick);
            ViewOrderButtonCommand = new RelayCommand(ViewOrderButtonClick);


            ContentControlBinding = new DefaultView();
        }

        #region Private Click Helpers
        private void AddOrderButtonClick()
        {
            ContentControlBinding = new AddOrderView();
            OnChanged(nameof(ContentControlBinding));
        }

        private void ViewOrderButtonClick()
        {
            ContentControlBinding = new ViewOrderView();

            OnChanged(nameof(ContentControlBinding));
        }
        #endregion
    }
}
