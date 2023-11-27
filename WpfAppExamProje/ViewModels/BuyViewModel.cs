using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfAppExamProje.Commands;
using WpfAppExamProje.Models;

namespace WpfAppExamProje.ViewModels
{

    public class BuyViewModel : INotifyPropertyChanged
    {
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

        private string _selectedMovieName;
        public string SelectedMovieName
        {
            get { return _selectedMovieName; }
            set
            {
                _selectedMovieName = value;
                OnPropertyChanged(nameof(SelectedMovieName));
            }
        }

        private string _selectedMovieSesions;
        public string SelectedMovieSesions
        {
            get { return _selectedMovieSesions; }
            set
            {
                _selectedMovieSesions = value;
                OnPropertyChanged(nameof(SelectedMovieSesions));
            }
        }

        private string _selectedMovieLocation;
        public string SelectedMovieLocation
        {
            get { return _selectedMovieLocation; }
            set
            {
                _selectedMovieLocation = value;
                OnPropertyChanged(nameof(SelectedMovieLocation));
            }
        }

        private string _selectedMovieHall;
        public string SelectedMovieHall
        {
            get { return _selectedMovieHall; }
            set
            {
                _selectedMovieHall = value;
                OnPropertyChanged(nameof(SelectedMovieHall));
            }
        }

        public BuyViewModel(string movieName, string sesions, string location, string hall)
        {
            SelectedMovieName = movieName;
            SelectedMovieSesions = sesions;
            SelectedMovieLocation = location;
            SelectedMovieHall = hall;
           
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler? handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }


    }
}
