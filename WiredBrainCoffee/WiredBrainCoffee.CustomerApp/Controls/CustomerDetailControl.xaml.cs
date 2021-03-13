using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;
using WiredBrainCoffee.CustomerApp.Model;

namespace WiredBrainCoffee.CustomerApp.Controls
{
    [ContentProperty(Name = nameof(Customer))]
    public sealed partial class CustomerDetailControl : UserControl
    {
        public static readonly DependencyProperty CustomerProperty =
            DependencyProperty.Register("Customer", typeof(Customer), typeof(CustomerDetailControl), new PropertyMetadata(null));
        //                               Ime propertia, klasa koja ima properti, vlasnik klase , povratna vrijednosti (null za string, 0 za int) i povratna funckija

        public CustomerDetailControl()
        {
            this.InitializeComponent();
        }

        public Customer Customer
        {
            get { return (Customer)GetValue(CustomerProperty); }
            set { SetValue(CustomerProperty, value); }
        }

       
        
    }
}
