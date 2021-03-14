using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using WiredBrainCoffee.CustomerApp.Model;
using WiredBrainCoffee.CustomerApp.Model.Base;
using WiredBrainCoffee.CustomersApp.DataProvider;

namespace WiredBrainCoffee.CustomerApp.ViewModel
{
    public class MainViewModel : Observable
    {
        private ICustomerDataProvider _customerDataProvider;
        private Customer _selectedCustomer;

        public MainViewModel(ICustomerDataProvider customerDataProvider)
        {
            _customerDataProvider = customerDataProvider;
            Customers = new ObservableCollection<Customer>();
        }

        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }
            set 
            {
                if (_selectedCustomer != value)
                {
                    _selectedCustomer = value;
                    OnPropertyChanged();
                }
            }
        }


        public ObservableCollection<Customer> Customers { get; }

        public async Task LoadAsync()
        {
            Customers.Clear();

            var customers = await _customerDataProvider.LoadCustomersAsync();

            foreach (var customer in customers)
            {
                Customers.Add(customer);
            }
        }

        

        internal async Task SaveAsync()
        {
            await _customerDataProvider.SaveCustomersAsync(Customers);
        }
    }
}
