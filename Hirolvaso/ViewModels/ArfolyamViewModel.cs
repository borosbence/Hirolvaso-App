using CommunityToolkit.Mvvm.ComponentModel;
using Hirolvaso.Models;
using Hirolvaso.Repositories;

namespace Hirolvaso.ViewModels
{
    public class ArfolyamViewModel : ObservableObject
    {
        private readonly GenericAPIRepository<Arfolyam> repository;

        public ArfolyamViewModel()
        {
            repository = new GenericAPIRepository<Arfolyam>(OldalTipus.Arfolyam);
            LoadDataAsync();
        }

        private DateOnly _idopont;
        public DateOnly Idopont
        {
            get { return _idopont; }
            set { SetProperty(ref _idopont, value); }
        }

        private double _euro;
        public double Euro
        {
            get { return _euro; }
            set { SetProperty(ref _euro, value); }
        }

        private double _dollar;
        public double Dollar
        {
            get { return _dollar; }
            set { SetProperty(ref _dollar, value); }
        }

        private async Task LoadDataAsync()
        {
            var response = await repository.GetValueAsync();
            Idopont = response.Date;
            Euro = Math.Round(response.Rates["HUF"], 2);
            Dollar = Math.Round(Euro * response.Rates["USD"], 2);
        }
    }
}
