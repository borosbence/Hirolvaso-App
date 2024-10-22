using Hirolvaso.Repositories;
using System.Collections.ObjectModel;

namespace Hirolvaso.ViewModels
{
    public class NevnapViewModel
    {
        private readonly GenericAPIRepository<Dictionary<string, List<string>>> repository;
        public ObservableCollection<string> Nevek { get; set; }

        public NevnapViewModel()
        {
            repository = new GenericAPIRepository<Dictionary<string, List<string>>>(OldalTipus.Nevnap);
            Nevek = new ObservableCollection<string>();
            _= LoadDataAsync();
        }
        
        public string Datum => DateTime.Now.ToString("M");

        private async Task LoadDataAsync()
        {
            Nevek.Clear();
            var response = await repository.GetValueAsync();
            var maiNevek = response.First().Value;
            foreach (var item in maiNevek)
            {
                Nevek.Add(item);
            }
        }
    }
}
