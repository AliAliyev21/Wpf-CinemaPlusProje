using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppExamProje.Models
{
    public class Hall : INotifyPropertyChanged
    {
        private string? _hall1;
        private string? _hall2;
        private string? _hall3;
        private string? _hall4;
        private string? _hall5;
        private string? _hall6;
        private string? _hall7;
        private string? _hall8;
        private string? _hall9;

        public string? Hall1
        {
            get { return _hall1; }
            set { _hall1 = value; OnPropertyChanged(); }
        }

        public string? Hall2
        {
            get { return _hall2; }
            set { _hall2 = value; OnPropertyChanged(); }
        }

        public string? Hall3
        {
            get { return _hall3; }
            set { _hall3 = value; OnPropertyChanged(); }
        }

        public string? Hall4
        {
            get { return _hall4; }
            set { _hall4 = value; OnPropertyChanged(); }
        }

        public string? Hall5
        {
            get { return _hall5; }
            set { _hall5 = value; OnPropertyChanged(); }
        }

        public string? Hall6
        {
            get { return _hall6; }
            set { _hall6 = value; OnPropertyChanged(); }
        }

        public string? Hall7
        {
            get { return _hall7; }
            set { _hall7 = value; OnPropertyChanged(); }
        }

        public string? Hall8
        {
            get { return _hall8; }
            set { _hall8 = value; OnPropertyChanged(); }
        }

        public string? Hall9
        {
            get { return _hall9; }
            set { _hall9 = value; OnPropertyChanged(); }
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
