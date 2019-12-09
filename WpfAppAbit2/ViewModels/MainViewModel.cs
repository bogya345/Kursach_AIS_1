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

        public ICommand ShowAddEntrant
        {
            get => new UserCommand(async () =>
            {
                var displayRootRegistry = (Application.Current as App).displayRootRegistry;

                var otherWindowViewModel = new AbitAddViewModel();
                await displayRootRegistry.ShowModalPresentation(otherWindowViewModel);
            }
            );
        }
    }
}
