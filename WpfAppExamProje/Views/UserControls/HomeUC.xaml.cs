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
using WpfAppExamProje.Models;
using WpfAppExamProje.ViewModels;

namespace WpfAppExamProje.Views.UserControls
{
    /// <summary>
    /// Interaction logic for HomeUC.xaml
    /// </summary>
    public partial class HomeUC : UserControl
    {
        public HomeUC()
        {
            InitializeComponent();
            var vm = new HomeViewModel();
            this.DataContext = vm;
        }
        #region ,

        private void Sessions_Click(object sender, RoutedEventArgs e)
        {
            ((HomeViewModel)DataContext).OpenDescription();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ((HomeViewModel)DataContext).OpenDescriptionFromTextBlock();
        }
        #endregion
    }
}
