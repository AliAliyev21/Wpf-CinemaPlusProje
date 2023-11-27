using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppExamProje.Models
{
    public class Movie:INotifyPropertyChanged
    {
        private string? _name;
        private string? _image;
        private string? _country;
        private string? _formatRu;
        private string? _formatEn;
        private string? _formatTr;
        private string? _formatAze;
        private string? _format2D;
        private string? _formatAzeSub;
        private string? _sesions;
        private string? _age;
        private string? _onScreens;
        private string? _director;
        private string? _actors;
        private string? _duration;
        private string? _genre;
        private string? _hall;
        private string? _location;
        private string? _language;
        private string? _formats;
        private string? _ageRestrictions;
        private double _price;
        private string? _tralierUrl;
        private string? _about;


        public string? TralierUrl
        {
            get { return _tralierUrl; }
            set { _tralierUrl = value; OnPropertyChanged(); }
        }

        public string? About
        {
            get { return _about; }
            set { _about = value; OnPropertyChanged(); }
        }

        public string? Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        public string? Image
        {
            get { return _image; }
            set { _image = value; OnPropertyChanged(); }
        }

        public string? Country
        {
            get { return _country; }
            set { _country = value; OnPropertyChanged(); }
        }

        public string? FormatRu
        {
            get { return _formatRu; }
            set { _formatRu = value; OnPropertyChanged(); }
        }

        public string? FormatEn
        {
            get { return _formatEn; }
            set { _formatEn = value; OnPropertyChanged(); }
        }

        public string? FormatTr
        {
            get { return _formatTr; }
            set { _formatTr = value; OnPropertyChanged(); }
        }

        public string? FormatAze
        {
            get { return _formatAze; }
            set { _formatAze = value; OnPropertyChanged(); }
        }

        public string? Format2D
        {
            get { return _format2D; }
            set { _format2D = value; OnPropertyChanged(); }
        }

        public string? FormatAzeSub
        {
            get { return _formatAzeSub; }
            set { _formatAzeSub = value; OnPropertyChanged(); }
        }

        public string? Sesions
        {
            get { return _sesions; }
            set { _sesions = value; OnPropertyChanged(); }
        }

        public string? Age
        {
            get { return _age; }
            set { _age = value; OnPropertyChanged(); }
        }

        public string? AgeRestrictions
        {
            get { return _ageRestrictions; }
            set { _ageRestrictions = value; OnPropertyChanged(); }
        }

        public string? OnScreens
        {
            get { return _onScreens; }
            set { _onScreens = value; OnPropertyChanged(); }
        }

        public string? Director
        {
            get { return _director; }
            set { _director = value; OnPropertyChanged(); }
        }

        public string? Actors
        {
            get { return _actors; }
            set { _actors = value; OnPropertyChanged(); }
        }

        public string? Duration
        {
            get { return _duration; }
            set { _duration = value; OnPropertyChanged(); }
        }

        public string? Genre
        {
            get { return _genre; }
            set { _genre = value; OnPropertyChanged(); }
        }

        public string? Hall
        {
            get { return _hall; }
            set { _hall = value; OnPropertyChanged(); }
        }

        public string? Location
        {
            get { return _location; }
            set { _location = value; OnPropertyChanged(); }
        }

        public string? Language
        {
            get { return _language; }
            set { _language = value; OnPropertyChanged(); }
        }

        public string? Formats
        {
            get { return _formats; }
            set { _formats = value; OnPropertyChanged(); }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; OnPropertyChanged(); }
        }

        private DateTime _dateTime;

        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; OnPropertyChanged(); }
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
