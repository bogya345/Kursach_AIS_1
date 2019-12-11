using System;
using System.Collections.Generic;
using System.ComponentModel;
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

using WpfAppAbit2.DAL;
using WpfAppAbit2.Services;
using WpfAppAbit2.Services.Excell;
using WpfAppAbit2.Services.Word;

namespace WpfAppAbit2.Views
{
    /// <summary>
    /// Логика взаимодействия для AbitAddView.xaml   
    /// </summary>
    public partial class AbitAddView : Window, IView
    {
        public AbitAddView()
        {
            // this.Resources = new ResourceDictionary() { Source = new Uri("pack://application:,,,/Resourses/AbitAddView.xaml") };
            //this.Style = (Style)Application.Current.Resources["AddAbit"];
            InitializeComponent();

            UnitOfWork unit = new UnitOfWork();

            Prikaz pr = new Prikaz();
            pr.SetContent(unit.Applications);
        }

        public IViewModel ViewModel
        {
            get => DataContext as IViewModel;
            set => DataContext = value;
        }

        private void Changed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
