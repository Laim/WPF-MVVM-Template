using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_Template.Core;

namespace WPF_MVVM_Template.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand GameViewCommand { get; set; }
        public RelayCommand ProfileViewCommand { get; set; }
        public RelayCommand AboutViewCommand { get; set; }


        public HomeViewModel HomeVM { get; set; }
        public GamesViewModel GameVM { get; set; }
        public ProfileViewModel ProfileVM { get; set; }
        public AboutViewModel AboutVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            GameVM = new GamesViewModel();
            ProfileVM = new ProfileViewModel();
            AboutVM = new AboutViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            GameViewCommand = new RelayCommand(o =>
            {
                CurrentView = GameVM;
            });

            ProfileViewCommand = new RelayCommand(o =>
            {
                CurrentView = ProfileVM;
            });

            AboutViewCommand = new RelayCommand(o =>
            {
                CurrentView = AboutVM;
            });

        }
    }
}
