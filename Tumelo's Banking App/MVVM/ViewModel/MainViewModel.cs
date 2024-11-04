using System;

using Tumelo_s_Banking_App.Core;
using Tumelo_s_Banking_App.MVVM.ViewModel;

namespace Tumelo_s_Banking_App.MVVM.View
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }

        public HomeViewModel HomeVM{ get; set; } 
        
        public DiscoveryViewModel DiscoveryVM{ get; set; }

        private object _currentView;
        
        public object MyProperty 
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
            
        }


        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            
            DiscoveryVM = new DiscoveryViewModel();
            _currentView = HomeVM;

            HomeViewCommand = new RelayCommand(O =>
            { 
            
            });
        }
    }
}
