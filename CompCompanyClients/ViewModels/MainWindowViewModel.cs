using CompCompanyClients.ViewModels;
using CompCompanyClients.Views;


namespace CompCompanyClients.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public GpuUserController _GpuUserController { get; set; }
        public MainWindowViewModel()
        {
            _GpuUserController = new GpuUserController();
            _GpuUserController.DataContext = new GpuUserControllerViewModel();
        }

    }
}