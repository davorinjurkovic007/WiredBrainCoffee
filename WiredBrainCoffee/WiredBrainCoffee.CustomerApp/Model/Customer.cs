using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffee.CustomerApp.Model.Base;

namespace WiredBrainCoffee.CustomerApp.Model
{
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
