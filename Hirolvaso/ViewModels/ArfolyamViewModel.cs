using Hirolvaso.Models;
using Hirolvaso.Repositories;
using System.Collections.ObjectModel;

namespace Hirolvaso.ViewModels
{
    public class ArfolyamViewModel
    {
        private readonly GenericAPIRepository<List<Valuta>> repository;
        public ObservableCollection<Valuta> Arfolyamok { get; set; }

        public string Idopont => DateTime.Now.ToString("HH:mm:ss");

        public ArfolyamViewModel()
        {
            repository = new GenericAPIRepository<List<Valuta>>(OldalTipus.Arfolyam);
            Arfolyamok = new ObservableCollection<Valuta>();
            LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            Arfolyamok.Clear();
            var response = await repository.GetValueAsync();
            foreach (var item in response)
            {
                Arfolyamok.Add(item);
            }
        }
    }
}
