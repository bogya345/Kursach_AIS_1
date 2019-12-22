using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfAppAbit2.DAL;
using WpfAppAbit2.Models;
using WpfAppAbit2.Patterns;
using WpfAppAbit2.Views;
namespace WpfAppAbit2.ViewModels
{
    public class MainViewModel  : ViewModelBase
    {
        //private readonly IRepository<Entrant> _entrantRepos;
        private ObservableCollection<EntrantApplication> _entrantApplications = new ObservableCollection<EntrantApplication>();
        public ObservableCollection<EntrantApplication> EntrantApplications { get=> _entrantApplications;  }
        public MainViewModel(IView view) : base(view)
        {
            _entrantApplications = unit.Applications.GetAll();
            View.Show();
        }
        public static LocalStorage db { get; set; } = new LocalStorage();
        public UnitOfWork unit { get; set; } = new UnitOfWork();
        public RepositoryEntrant entrants { get; set; } = new RepositoryEntrant(db);
        public RepositoryApplication applications { get; set; } = new RepositoryApplication(db);
        public ICommand ShowAddEntrant
        {
            get => new UserCommand(async () =>
            {
                var displayRootRegistry = (Application.Current as App).displayRootRegistry;
                LocalStorage localStorage = new LocalStorage();                
                var otherWindowViewModel = new AbitAddViewModel(new AbitAddView(), unit);
                await displayRootRegistry.ShowModalPresentation(otherWindowViewModel);
            }
            );
        }
        public void CloseCampaignFunc()
        {
            unit.Campaigns.
        }
        public ICommand CloseCampaign
        {
            get => new UserCommand(() =>
            {
                CloseCampaignFunc();
            }
            );
        }
        public 
        //public ObservableCollection<Application> LoadApplications()
        //{
        //    return unit.Applications.GetAll();
        //}
    }
}
