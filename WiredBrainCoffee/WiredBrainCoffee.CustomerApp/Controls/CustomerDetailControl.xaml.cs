using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WiredBrainCoffee.CustomerApp.Model;

namespace WiredBrainCoffee.CustomerApp.Controls
{
    public sealed partial class CustomerDetailControl : UserControl
    {
        private Customer customer;

        public CustomerDetailControl()
        {
            this.InitializeComponent();
        }

        public Customer Customer
        {
            get { return customer; }
            set 
            { 
                customer = value;
                txtFirstName.Text = customer?.FirstName ?? "";
                txtLastName.Text = customer?.LastName ?? "";
                chkIsDeveloper.IsChecked = customer?.IsDeveloper;
            }
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateCustomer();
        }

        private void CheckBox_IsCheckedChanged(object sender, RoutedEventArgs e)
        {
            UpdateCustomer();
        }

        private void UpdateCustomer()
        {
            if (customer != null)
            {
                customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.IsDeveloper = chkIsDeveloper.IsChecked.GetValueOrDefault();
            }
        }
    }
}
