using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfAppExamProje.Models;
using WpfAppExamProje.ViewModels;

namespace WpfAppExamProje.Views.UserControls
{
    /// <summary>
    /// Interaction logic for DescriptionUC.xaml
    /// </summary>
    public partial class DescriptionUC : UserControl
    {   
        public DescriptionUC()
        {
            InitializeComponent();
            var vm=new DescriptionViewModel();
            this.DataContext = vm;

        }
    }
}
