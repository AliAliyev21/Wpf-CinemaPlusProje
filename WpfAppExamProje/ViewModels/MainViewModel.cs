using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAppExamProje.Commands;
using WpfAppExamProje.Views.UserControls;

namespace WpfAppExamProje.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public RelayCommand HomeCommand { get; set; }
        public RelayCommand TodayCommand { get; set; }
        public RelayCommand ScheduleCommand { get; set; }
        public RelayCommand SearchCommand { get; set; }
        public MainViewModel()
        {
            var homeViewModel = new HomeViewModel();
            var homeUC = new HomeUC();
            homeUC.DataContext = homeViewModel;
            
            App.MyGrid.Children.Add(homeUC);

            HomeCommand = new RelayCommand((obj) =>
            {
                App.MyGrid.Children.Clear();

                var vm = new HomeViewModel();
                var view = new HomeUC();
                view.DataContext = vm;

                IsTodaySelected = true;
                IsScheduleSelected = false;
                IsSearchActive = false;
                App.MyGrid.Children.Add(view);
            });

            TodayCommand = new RelayCommand((obj) =>
            {
                App.MyGrid.Children.Clear();

                var vm = new HomeViewModel();
                var view = new HomeUC();
                view.DataContext = vm;

              
                App.MyGrid.Children.Add(view);
            });

            ScheduleCommand = new RelayCommand((obj) =>
            {
                App.MyGrid.Children.Clear();

                var vm = new ScheduleViewModel();
                var view = new ScheduleUC();
                view.DataContext = vm;

                App.MyGrid.Children.Add(view);
            });

            SearchCommand = new RelayCommand((obj) =>
            {
                App.MyGrid.Children.Clear();

                var vm=new SearchViewModel();
                var view = new SearchUC();
                view.DataContext = vm;

                IsTodaySelected = false;
                IsScheduleSelected = false;
                IsSearchActive = true;
                App.MyGrid.Children.Add(view);
            });

        }


        private bool _isTodaySelected;
        public bool IsTodaySelected
        {
            get { return _isTodaySelected; }
            set
            {
                if (_isTodaySelected != value)
                {
                    _isTodaySelected = value;
                    OnPropertyChanged(nameof(IsTodaySelected));
                    IsScheduleSelected = !value;
                }
            }
        }

        private bool _isScheduleSelected;
        public bool IsScheduleSelected
        {
            get { return _isScheduleSelected; }
            set
            {
                if (_isScheduleSelected != value)
                {
                    _isScheduleSelected = value;
                    OnPropertyChanged(nameof(IsScheduleSelected));
                    IsTodaySelected = !value;
                }
            }
        }


        private bool _isSearchActive;
        public bool IsSearchActive
        {
            get { return _isSearchActive; }
            set
            {
                if (_isSearchActive != value)
                {
                    _isSearchActive = value;
                    OnPropertyChanged(nameof(IsSearchActive));
                    if (value)
                    {
                        IsTodaySelected = false;
                        IsScheduleSelected = false;
                    }
                }
            }
        }
    }
}
