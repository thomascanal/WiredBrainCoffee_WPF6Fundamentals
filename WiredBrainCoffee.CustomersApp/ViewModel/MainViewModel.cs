using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBrainCoffee.CustomersApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase? _selectedViewModel;
        private CustomersViewModel _customersViewModel;
        private ProductsViewModel _productsViewModel;

        public MainViewModel(CustomersViewModel customersViewModel,
            ProductsViewModel productsViewModel)
        {
            _customersViewModel = customersViewModel;
            _productsViewModel = productsViewModel;
            SelectedViewModel = _customersViewModel;
        }
        public ViewModelBase? SelectedViewModel
        {
            get => _selectedViewModel;
            set
            {
                _selectedViewModel = value;
                RaisePropertyChanged();
            }
        }

        public async override Task LoadAsync()
        {
            if (SelectedViewModel is not null)
            {
                await SelectedViewModel.LoadAsync();
            }
        }
    }
}
