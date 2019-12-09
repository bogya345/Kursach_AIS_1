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

using WpfAppAbit2.Models;
using WpfAppAbit2.Repository;
using WpfAppAbit2.XML;

namespace WpfAppAbit2.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainView : Window, IView
    {
        //public List<IAbitAddViewModel> abits;
        private TreeViewItem priveousItem = null;

        public static LocalStorage db = new LocalStorage();

        public RepositoryEntrant entrants = new RepositoryEntrant(db);
        public RepositoryApplication apps = new RepositoryApplication(db);

        public MainView()
        {
            //entrantsGrid.ItemsSource = 
            InitializeComponent();
            entrantsGrid.ItemsSource = entrants.GetAll();
        }
        public IViewModel ViewModel
        {
            get => DataContext as IViewModel;
            set => DataContext = value;
        }

        public void OpenAdd(object sender, RoutedEventArgs e)
        {

        }
        private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvItem = (TreeViewItem)sender;

            MessageBox.Show("Узел " + tvItem.Header.ToString() + " раскрыт");
        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvItem = (TreeViewItem)sender;
            MessageBox.Show("Выбран узел: " + tvItem.Header.ToString());

            if (priveousItem == null || priveousItem != tvItem)
                SwitchAbitsList(tvItem);
        }

        private void SwitchAbitsList(TreeViewItem item)
        {
            //abits = new List<IAbitAddViewModel>();

            switch (item.Header.ToString().ToLower())
            {
                case "втисит":
                    {
                        entrants.GetAll().Where(x => x.IsFromKrym);
                        break;
                    }
            }
        }

        private void TreeView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //SelectItem = Transform.ttyt;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            xml _xml = new xml(apps.GetAll());
            _xml.SetContent();
        }
    }
}
