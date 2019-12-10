using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfAppAbit2.Models;
using WpfAppAbit2.Patterns;
using WpfAppAbit2.Views;
namespace WpfAppAbit2.ViewModels
{
    public class MainViewModel  : ViewModelBase
    {
        //private readonly IRepository<Entrant> _entrantRepos;

        public MainViewModel(IView view) : base(view)
        {
            View.Show();
        }
        public static LocalStorage db { get; set; } = new LocalStorage();

        public RepositoryEntrant entrants { get; set; } = new RepositoryEntrant(db);
        public RepositoryApplication applications { get; set; } = new RepositoryApplication(db);
        public ICommand ShowAddEntrant
        {
            get => new UserCommand(async () =>
            {
                var displayRootRegistry = (Application.Current as App).displayRootRegistry;
                LocalStorage localStorage = new LocalStorage();
                
                var otherWindowViewModel = new AbitAddViewModel(new AbitAddView());
                await displayRootRegistry.ShowModalPresentation(otherWindowViewModel);
            }
            );
        }
    }
}
