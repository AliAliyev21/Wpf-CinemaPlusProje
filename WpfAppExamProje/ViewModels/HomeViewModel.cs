using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfAppExamProje.Commands;
using WpfAppExamProje.Models;
using WpfAppExamProje.Views.UserControls;

namespace WpfAppExamProje.ViewModels
{
    public class HomeViewModel:BaseViewModel
    {
        private CommonDataService _commonDataService;

        public ObservableCollection<Facilities> AllFacilities => _commonDataService.AllFacilities;

        public ObservableCollection<Languages> AllLanguages => _commonDataService.AllLanguages;

        public ObservableCollection<Movie> AllMovies => _commonDataService.AllMovies;

        public RelayCommand EnglishCommand { get; set; }
      
        public HomeViewModel()
        {
            _commonDataService = new CommonDataService();

            EnglishCommand = new RelayCommand((obj) =>
            {
                FilterMovies();
            });

            

            FilteredMovies = new ObservableCollection<Movie>(AllMovies);

            SelectedFacility = AllFacilities.FirstOrDefault();
            SelectedLanguage = AllLanguages.FirstOrDefault();

        }

        private string searcText;
        public string SearcText
        {
            get { return searcText; }
            set { searcText = value; OnPropertyChanged(); }
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

        private bool _isEnglishChecked;
        public bool IsEnglishChecked
        {
            get { return _isEnglishChecked; }
            set
            {
                _isEnglishChecked = value;
                FilterMovies();
                OnPropertyChanged(nameof(IsEnglishChecked));
            }
        }

        private Movie _selectedMovie;
        public Movie SelectedMovie
        {
            get { return _selectedMovie; }
            set
            {
                _selectedMovie = value;
                OnPropertyChanged(nameof(SelectedMovie));
            }
        }

        public void OpenDescription()
        {
            try
            {
                var selectedMovie = SelectedMovie;

                var vm = new DescriptionViewModel();
                vm.SelectedMovie = selectedMovie;

                var view = new DescriptionUC();
                view.DataContext = vm;
                App.MyGrid.Children.Add(view);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void OpenDescriptionFromTextBlock()
        {
            try
            {
                var selectedMovie = SelectedMovie;

                var vm = new DescriptionViewModel();
                vm.SelectedMovie = selectedMovie;

                var view = new DescriptionUC();
                view.DataContext = vm;
                App.MyGrid.Children.Add(view);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void FilterMovies()
        {
            if (SelectedFacility != null && SelectedLanguage != null)
            {
                FilteredMovies.Clear();
                foreach (var movie in AllMovies.Where(movie =>
                    movie.Location.Split(',').Select(loc => loc.Trim()).Contains(SelectedFacility.Name) &&
                    (SelectedLanguage.Language == "All languages" || movie.Language.ToLower().Contains(SelectedLanguage.Language.ToLower()))
                ))
                {
                    FilteredMovies.Add(movie);
                }

                if (IsEnglishChecked)
                {
                    FilteredMovies = new ObservableCollection<Movie>(FilteredMovies.Where(movie =>
                        movie.Language.ToLower().Contains("english")
                    ));
                }
            }
        }
    }
}
