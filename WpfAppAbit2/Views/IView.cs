using WpfAppAbit2.ViewModels;

namespace WpfAppAbit2.Views
{
    public interface IView
    {
        IViewModel ViewModel { get; set; }
        void UpdateList();
        void Show();
    }
}
