using System;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WiredBrainCoffee.CustomerApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void ButtonAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            var messageDialog = new MessageDialog("Custome added!");
            await messageDialog.ShowAsync();
        }

        private void ButtonDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonMove_Click(object sender, RoutedEventArgs e)
        {
            //int column = (int)customerListGrid.GetValue(Grid.ColumnProperty);
            int column = Grid.GetColumn(customerListGrid);

            int newColumn = column == 0 ? 2 : 0;

            //customerListGrid.SetValue(Grid.ColumnProperty, newColumn);
            Grid.SetColumn(customerListGrid, newColumn);

            moveSymbolIcon.Symbol = newColumn == 0 ? Symbol.Forward : Symbol.Back;
        }
    }
}
