using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppExamProje.Commands;
using WpfAppExamProje.Models;
using WpfAppExamProje.Views.UserControls;

namespace WpfAppExamProje.ViewModels
{
    public class ScheduleViewModel:BaseViewModel
    {

        private CommonDataService _commonDataService;
        public ObservableCollection<Facilities> AllFacilities => _commonDataService.AllFacilities;
        public ObservableCollection<Languages> AllLanguages => _commonDataService.AllLanguages;
        public ObservableCollection<Movie> AllMovies => _commonDataService.AllMovies;
        public ObservableCollection<Hall> AllHalls => _commonDataService.AllHalls;
        public ObservableCollection<MovieTime> AllTimes => _commonDataService.AllTimes;
      
        public ScheduleViewModel()
        {
            _commonDataService = new CommonDataService();



            FilteredMovies = new ObservableCollection<Movie>(AllMovies);

            SelectedFacility = AllFacilities.FirstOrDefault();
            SelectedLanguage = AllLanguages.FirstOrDefault();

            AllMovieTimes = _commonDataService.AllTimes;
            SelectedDate = DateTime.Now;         
        }

        private ObservableCollection<MovieTime> _allMovieTimes;
        public ObservableCollection<MovieTime> AllMovieTimes
        {
            get { return _allMovieTimes; }
            set
            {
                _allMovieTimes = value;
                OnPropertyChanged(nameof(AllMovieTimes));
            }
        }

        private DateTime _selectedDate;
        public DateTime SelectedDate
        {
            get { return _selectedDate; }
            set
            {
                _selectedDate = value;
                FilterMovies();
                OnPropertyChanged(nameof(SelectedDate));
            }
        }

        private Facilities _selectedFacility;
        public Facilities SelectedFacility
        {
            get { return _selectedFacility; }
            set
            {
                _selectedFacility = value;
                FilterMovies();
                OnPropertyChanged(nameof(SelectedFacility));
            }
        }

        private Languages _selectedLanguage;
        public Languages SelectedLanguage
        {
            get { return _selectedLanguage; }
            set
            {
                _selectedLanguage = value;
                FilterMovies();
                OnPropertyChanged(nameof(SelectedLanguage));
            }
        }

        private ObservableCollection<Movie> _filteredMovies;
        public ObservableCollection<Movie> FilteredMovies
        {
            get { return _filteredMovies; }
            set
            {
                _filteredMovies = value;
                OnPropertyChanged(nameof(FilteredMovies));
            }
        }

        private bool _isTodayChecked;
        public bool IsTodayChecked
        {
            get { return _isTodayChecked; }
            set
            {
                if (value != _isTodayChecked)
                {
                    _isTodayChecked = value;
                    if (value)
                    {
                        _isTomorrowChecked = false;

                        SelectedDate = DateTime.Now;
                        FilterMovies();
                    }
                    OnPropertyChanged(nameof(IsTodayChecked));
                    OnPropertyChanged(nameof(IsTomorrowChecked));
                }
            }
        }

        private bool _isTomorrowChecked;
        public bool IsTomorrowChecked
        {
            get { return _isTomorrowChecked; }
            set
            {
                if (value != _isTomorrowChecked)
                {
                    _isTomorrowChecked = value;
                    if (value)
                    {
                        _isTodayChecked = false;

                        SelectedDate = DateTime.Now.AddDays(1);
                        FilterMovies();
                    }
                    OnPropertyChanged(nameof(IsTomorrowChecked));
                    OnPropertyChanged(nameof(IsTodayChecked));
                }
            }
        }

        private void FilterMovies()
        {
            if (SelectedFacility != null && SelectedLanguage != null)
            {
                FilteredMovies.Clear();

                foreach (var movie in AllMovies.Where(movie =>
                    movie.Location.Split(',').Select(loc => loc.Trim()).Contains(SelectedFacility.Name) &&
                    (SelectedLanguage.Language == "All languages" || movie.Language.ToLower().Contains(SelectedLanguage.Language.ToLower())) &&
                    movie.DateTime.Date == SelectedDate.Date
                ))
                {
                    FilteredMovies.Add(movie);
                }
            }
        }

        public void Buy()
        {
            var selectedMovie = FilteredMovies.FirstOrDefault();
            var vm = new BuyViewModel(selectedMovie?.Name, selectedMovie?.Sesions, selectedMovie?.Location, selectedMovie?.Hall);
            var view = new BuyWindow();
            view.DataContext = vm;
            view.Show();
        }
    }
}
