using CompCompanyClients.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CompCompanyClients.ViewModels
{
    public class CpuUserControllerViewModel : ViewModelBase
    {
        private Cpu _selectedCpu;
        public Cpu SelectedCpu
        {
            get => _selectedCpu;
            set => this.RaiseAndSetIfChanged(ref _selectedCpu, value);
        }
        private HttpClient client = new HttpClient();
        private ObservableCollection<Cpu> _cpus;
        public ObservableCollection<Cpu> Cpus
        {
            get => _cpus;
            set => this.RaiseAndSetIfChanged(ref _cpus, value);
        }

        private string _message;
        public string Message
        {
            get => _message;
            set => this.RaiseAndSetIfChanged(ref _message, value);
        }

        public CpuUserControllerViewModel()
        {
            client.BaseAddress = new Uri("http://localhost:5068/Cpus");
            Update();
        }

        public async Task Update()
        {
            var response = await client.GetAsync("");
            if (!response.IsSuccessStatusCode)
            {
                Message = $"Ошибка сервера {response.StatusCode}";
                return;
            }
            var content = await response.Content.ReadAsStringAsync();
            if (content == null)
            {
                Message = "Пустой ответ от сервера";
                return;
            }
            Cpus = JsonSerializer.Deserialize<ObservableCollection<Cpu>>(content);
            Message = "";

        }
        

        public async Task DeleteAsync()
        {
            if (SelectedCpu == null) return;
            var response = await client.DeleteAsync($"/Cpu/{SelectedCpu.Id}");
            if (!response.IsSuccessStatusCode)
            {
                Message = "Ошибка удаления со стороны сервера";
                return;
            }
            Cpus.Remove(SelectedCpu);
            SelectedCpu = null;
            Message = "";
        }

        public void Add()
        {

        }

        public void Edit()
        {

        }
    }
}
