using ModernDesign.Core;

namespace ModernDesign.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand ConfigViewCommand { get; set; }

        public RelayCommand ThemeViewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }

        public ConfigViewModel ConfigVm { get; set; }

        public ThemeViewModel ThemeVm { get; set; }

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
            ThemeVm = new ThemeViewModel();
            CurrentView = HomeVm; 

            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentView = HomeVm;
            });

            ConfigViewCommand = new RelayCommand(o =>
            {
                CurrentView = ConfigVm;
            });

            ThemeViewCommand = new RelayCommand(o =>
            {
                CurrentView = ThemeVm;
            });
        }

    }
}
