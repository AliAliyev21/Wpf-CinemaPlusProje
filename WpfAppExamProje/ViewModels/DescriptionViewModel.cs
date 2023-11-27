using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using WpfAppExamProje.Models;

namespace WpfAppExamProje.ViewModels
{
    public class DescriptionViewModel:INotifyPropertyChanged
    {

        private CommonDataService _commonDataService;
        public ObservableCollection<Movie> AllMovies => _commonDataService.AllMovies;

        private Movie _selectedMovie;
        public Movie SelectedMovie
        {
            get { return _selectedMovie; }
            set
            {
                _selectedMovie = value;
                SelectedMovieImage = value?.Image;
                SelectedFormats=value?.Formats;
                SelectedScreens = value?.OnScreens;
                SelectedCountry=value?.Country;
                SelectedDirector=value?.Director;
                SelectedActors=value?.Actors;
                SelectedDuration=value?.Duration;
                SelectedGenre=value?.Genre;
                SelectedAge = value?.Age;
                SelectedAbout=value?.About;
                SelectedTrailerUrl = value?.TralierUrl;
                OnPropertyChanged(nameof(SelectedMovie));
            }
        }

        private string _selectedAbout;
        public string SelectedAbout
        {
            get { return _selectedAbout; }
            set
            {
                _selectedAbout = value;
                OnPropertyChanged(nameof(SelectedAbout));
            }
        }

        private string _selectedTrailerUrl;
        public string SelectedTrailerUrl
        {
            get { return _selectedTrailerUrl; }
            set
            {
                _selectedTrailerUrl = value;
                OnPropertyChanged(nameof(SelectedTrailerUrl));
            }
        }

        private string _selectedMovieImage;
        public string SelectedMovieImage
        {
            get { return _selectedMovieImage; }
            set
            {
                _selectedMovieImage = value;
                OnPropertyChanged(nameof(SelectedMovieImage));
            }
        }

        private string _selectedFormats;
        public string SelectedFormats
        {
            get { return _selectedFormats; }
            set { _selectedFormats = value; OnPropertyChanged(nameof(SelectedFormats)); }
        }

        private string _selectedScreens;
        public string SelectedScreens
        {
            get { return _selectedScreens; }
            set { _selectedScreens = value; OnPropertyChanged(nameof(SelectedScreens)); }
        }

        private string _selectedCountry;
        public string SelectedCountry
        {
            get { return _selectedCountry; }
            set { _selectedCountry = value; OnPropertyChanged(nameof(SelectedCountry)); }
        }

        private string _selectedDirector;
        public string SelectedDirector
        {
            get { return _selectedDirector; }
            set { _selectedDirector = value; OnPropertyChanged(nameof(SelectedDirector)); }
        }

        private string _selectedActors;
        public string SelectedActors
        {
            get { return _selectedActors; }
            set { _selectedActors = value; OnPropertyChanged(nameof(SelectedActors)); }
        }

        private string _selectedDuration;
        public string SelectedDuration
        {
            get { return _selectedDuration; }
            set { _selectedDuration = value; OnPropertyChanged(nameof(SelectedDuration)); }
        }

        private string _selectedGenre;
        public string SelectedGenre
        {
            get { return _selectedGenre; }
            set { _selectedGenre = value; OnPropertyChanged(nameof(SelectedGenre)); }
        }

        private string _selectedAge;
        public string SelectedAge
        {
            get { return _selectedAge; }
            set { _selectedAge = value; OnPropertyChanged(nameof(SelectedAge)); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public DescriptionViewModel()
        {
            _commonDataService = new CommonDataService();
        }
    }
}
