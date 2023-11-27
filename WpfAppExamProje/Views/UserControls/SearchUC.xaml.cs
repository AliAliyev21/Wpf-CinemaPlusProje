using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppExamProje.ViewModels;

namespace WpfAppExamProje.Views.UserControls
{
    /// <summary>
    /// Interaction logic for SearchUC.xaml
    /// </summary>
    public partial class SearchUC : UserControl
    {
        public SearchUC()
        {
            InitializeComponent();
            var vm=new SearchViewModel();
            this.DataContext = vm;
        }
        #region ,

        public string ImagePath { get; set; }
        public string Minute { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public dynamic Data { get; set; }
        public dynamic SingleData { get; set; }

        HttpClient client = new HttpClient();
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            var name = movieTextbox.Text;
            HttpResponseMessage response = new HttpResponseMessage();
            response = client.GetAsync($@"http://www.omdbapi.com/?apikey=ddee1dae&s={name}&plot=full").Result;

            var str = response.Content.ReadAsStringAsync().Result;
            Data = JsonConvert.DeserializeObject(str);

            var firstMovieTitle = Data.Search[0].Title;

            response = client.GetAsync($@"http://www.omdbapi.com/?apikey=ddee1dae&t={firstMovieTitle}&plot=full").Result;
            str = response.Content.ReadAsStringAsync().Result;
            SingleData = JsonConvert.DeserializeObject(str);

            movieLabel.Content = SingleData.Title + " " + SingleData.RunTime + " " + SingleData.Description;
            movieImage.Source= SingleData.Poster;
            movieImage2.Source = SingleData.Poster;
            
        }
        #endregion
    }
}
