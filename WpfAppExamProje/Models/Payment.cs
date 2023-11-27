using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppExamProje.Models
{
    public class Payment : INotifyPropertyChanged
    {
        private string? _name;
        private DateTime? _time;
        private string? _sesions;
        private string? _location;
        private string? _hall;

        public string ? Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        public string? Sesions
        {
            get { return _sesions; }
            set { _sesions = value; OnPropertyChanged(); }
        }

        public string? Location
        {
            get { return _location; }
            set { _location = value; OnPropertyChanged(); }
        }

        public string? Hall
        {
            get { return _hall; }
            set { _hall = value; OnPropertyChanged(); }
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
