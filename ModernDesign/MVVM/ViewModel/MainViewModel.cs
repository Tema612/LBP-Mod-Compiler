using ModernDesign.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand ConfigViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }

        public ConfigViewModel ConfigVm { get; set; }

        private object _currentView;

        public object CurrentView
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
            HomeVm = new HomeViewModel();
            ConfigVm = new ConfigViewModel();
            CurrentView = HomeVm; 

            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentView = HomeVm;
            });

            ConfigViewCommand = new RelayCommand(o =>
            {
                CurrentView = ConfigVm;
            });
        }

    }
}
