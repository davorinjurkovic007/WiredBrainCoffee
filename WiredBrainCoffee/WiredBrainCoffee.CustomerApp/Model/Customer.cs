using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using WiredBrainCoffee.CustomerApp.Model.Base;

namespace WiredBrainCoffee.CustomerApp.Model
{
    [CreateFromString(MethodName = "WiredBrainCoffee.CustomerApp.Model.CustomerConverter.CreateCustomerFromString")]
    public class Customer : Observable
    {
        private string firstName;
        private string lastName;
        private bool isDeveloper;

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                OnPropertyChanged();
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                OnPropertyChanged();
            }
        }
        public bool IsDeveloper
        {
            get => isDeveloper;
            set
            {
                isDeveloper = value;
                OnPropertyChanged();
            }
        }
    }
}
