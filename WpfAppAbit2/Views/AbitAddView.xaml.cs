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
using System.Windows.Shapes;
using WpfAppAbit2.ViewModels;

namespace WpfAppAbit2.Views
{
    /// <summary>
    /// Логика взаимодействия для AbitAddView.xaml   
    /// </summary>
    public partial class AbitAddView : Window, IView
    {
        public AbitAddView()
        {
            //this.Resources = new ResourceDictionary() { Source = new Uri("pack://application:,,,/Resourses/AbitAddViewRes.xaml") };
            //this.Resources = new ResourceDictionary() { Source = new Uri("pack://siteoforigin:,,,/,,Resourses/AbitAddViewRes.xaml") };
            //this.Resources = new ResourceDictionary() { Source = new Uri("pack://siteoforigin:,,,/AbitAddViewRes.xaml") };
            //this.Resources = new ResourceDictionary() { Source = new Uri("pack://application:,,,//AbitAddViewRes.xaml") };
            //this.Resources = new ResourceDictionary() { Source = new Uri("pack://application:,,,/ReferencedAssembly;/../../Resourses/AbitAddViewRes.xaml") };

            this.Style = (Style)Application.Current.Resources["AddAbit"];

            InitializeComponent();
        }
        public IViewModel ViewModel
        {
            get => DataContext as IViewModel;
            set => DataContext = value;
        }
  

    }
}
