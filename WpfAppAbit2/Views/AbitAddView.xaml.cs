using System.Threading;
using System.Windows;
using System.Windows.Controls;
using WpfAppAbit2.Services.Excell;
using WpfAppAbit2.ViewModels;

using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfAppAbit2.Services;
using WpfAppAbit2.Services.Excell;
using WpfAppAbit2.Services.Word;
using WpfAppAbit2.DAL;

namespace WpfAppAbit2.Views
{
    /// <summary>
    /// Логика взаимодействия для AbitAddView.xaml   
    /// </summary>
    public partial class AbitAddView : Window, IView
    {
       // private SynchronizationContext uiContext;
        public AbitAddView()
        {
            // this.Resources = new ResourceDictionary() { Source = new Uri("pack://application:,,,/Resourses/AbitAddView.xaml") };
            //this.Style = (Style)Application.Current.Resources["AddAbit"];
            InitializeComponent();
            //  uiContext = SynchronizationContext.Current;
            UnitOfWork unit = new UnitOfWork();

            //Prikaz pr = new Prikaz();
            //pr.SetContent(unit.Applications);

            //ServiceExcell service = new ServiceExcell();

            //service.AbitDopSpec = new AbitDopSpec(2);
            //service.AbitDopSpec.SetContent();
        }
        Binding binding = new Binding();

        public void UpdateList()
        {
           // changed2.Items.Refresh();
            //changed.Items.Refresh();
        }
        public IViewModel ViewModel
        {
            get => DataContext as IViewModel;
            set => DataContext = value;
        }

        private void Changed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            try
            {
              //  MessageBox.Show(changed2.Items[0].ToString());
            }
            catch { }
            UpdateList();
        }

        private void DatePicker_SourceUpdated(object sender, System.Windows.Data.DataTransferEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          //  BindingExpression BindingExpression = new BindingExpression(binding) ;
          //  BindingExpression.UpdateSource();

        }
    }
}
