using CompCompanyClients;
using CompCompanyClients.ViewModels;
using CompCompanyClients.Views;


namespace CompCompanyClients.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            _CpuUserController = new CpuUserController();
            _CpuUserController.DataContext = new CpuUserControllerViewModel();
        }

        public CpuUserController _CpuUserController { get; set; }
    }
}