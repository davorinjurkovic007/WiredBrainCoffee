using System.Collections.Generic;
using System.Threading.Tasks;
using WiredBrainCoffee.CustomerApp.Model;

namespace WiredBrainCoffee.CustomersApp.DataProvider
{
    public interface ICustomerDataProvider
    {
        Task<IEnumerable<Customer>> LoadCustomersAsync();
        Task SaveCustomersAsync(IEnumerable<Customer> customers);
    }
}