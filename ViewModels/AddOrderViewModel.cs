using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp4.Commands;

namespace WpfApp4.ViewModels
{
    public class AddOrderViewModel : BaseViewModel
    {
        #region TextBlock Content
        public string ItemNameTextBlock { get; private set; }
        public string ItemPriceTextBlock { get; private set; }
        public string ItemPaidTextBlock { get; private set; }
        #endregion

        #region TextBox Content
        public string ItemNameTextBox { get; set; }
        public string ItemPriceTextBox { get; set; }
        #endregion

        #region Paid CheckBox
        public bool IsPaid { get; set; }
        #endregion

        #region Add Button Content/Command
        public string AddButtonText { get; private set; }
        public ICommand AddButtonCommand { get; private set; }
        #endregion

        #region Constructor
        public AddOrderViewModel()
        {
            ItemNameTextBlock = "Item Name:";
            ItemPriceTextBlock = "Item Price:";
            ItemPaidTextBlock = "Paid";

            ItemNameTextBox = string.Empty;
            ItemPriceTextBox = string.Empty;

            IsPaid = false;

            AddButtonText = "Add Order";

            AddButtonCommand = new RelayCommand(AddButtonClick);
        }
        #endregion

        private void AddButtonClick()
        {

        }

    }
}