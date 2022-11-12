using CommunityToolkit.Mvvm.ComponentModel;
using Hirolvaso.Models;
using Hirolvaso.Repositories;

namespace Hirolvaso.ViewModels
{
    public class IdojarasViewModel : ObservableObject
    {
        private readonly GenericAPIRepository<Idojaras> repository;

        public IdojarasViewModel()
        {
            repository = new GenericAPIRepository<Idojaras>(OldalTipus.Idojaras);
            Task.Run(async () =>
                await LoadDataAsync());
        }

        private string helyszin;
        public string Helyszin
        {
            get { return helyszin; }
            set { SetProperty(ref helyszin, value); }
        }

        private string leiras;
        public string Leiras
        {
            get { return leiras; }
            set { SetProperty(ref leiras, value); }
        }

        private string keplink;
        public string KepLink
        {
            get { return keplink; }
            set { SetProperty(ref keplink, value); }
        }

        private int hofok;
        public int Hofok
        {
            get { return hofok; }
            set { SetProperty(ref hofok, value); }
        }

        private int min;
        public int Min
        {
            get { return min; }
            set { SetProperty(ref min, value); }
        }

        private int max;
        public int Max
        {
            get { return max; }
            set { SetProperty(ref max, value); }
        }

        private bool isRefreshing;
        public bool IsRefreshing
        {
            get { return isRefreshing; }
            set { SetProperty(ref isRefreshing, value); }
        }

        private async Task LoadDataAsync()
        {
            Idojaras model = await repository.GetValueAsync();
            Helyszin = model.Location;
            Leiras = model.Description;
            KepLink = "http://openweathermap.org/img/wn/" + model.Icon + "@2x.png";
            Hofok = model.Temperature;
            Min = model.Min;
            Max = model.Max;
        }
    }
}
