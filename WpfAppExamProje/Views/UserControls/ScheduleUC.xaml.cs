using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for ScheduleUC.xaml
    /// </summary>
    public partial class ScheduleUC : UserControl
    {
        public ScheduleUC()
        {
            InitializeComponent();
            var vm = new ScheduleViewModel();
            this.DataContext = vm;
        }

        #region ,

        private void BuyNow_Click(object sender, RoutedEventArgs e)
        {
            ((ScheduleViewModel)DataContext).Buy();            
        }
        #endregion
    }
}
