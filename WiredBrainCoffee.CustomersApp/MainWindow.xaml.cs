using System.Windows;
using System.Windows.Controls;

namespace WiredBrainCoffee.CustomersApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonMoveNavigation_Click(object sender, RoutedEventArgs e)
        {
            var column = (int)customerListGrid.GetValue(Grid.ColumnProperty);

            var newColumn = column == 0 ? 2 : 0;
            customerListGrid.SetValue(Grid.ColumnProperty, newColumn);
        }
    }
}
