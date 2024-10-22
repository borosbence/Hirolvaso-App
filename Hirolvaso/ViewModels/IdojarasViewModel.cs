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
            _= LoadDataAsync();
        }

        private string helyszin;
        public string Helyszin
        {
            get { return helyszin; }
            set { SetProperty(ref helyszin, value); }
        }

        private string keplink;
        public string KepLink
        {
            get { return keplink; }
            set { SetProperty(ref keplink, value); }
        }

        private double _celsius;
        public double Celsius
        {
            get { return _celsius; }
            set { SetProperty(ref _celsius, value); }
        }

        private double _szelsebesseg;
        public double Szelsebesseg
        {
            get { return _szelsebesseg; }
            set { SetProperty(ref _szelsebesseg, value); }
        }

        private int _paratartalom;
        public int Paratartalom
        {
            get { return _paratartalom; }
            set { SetProperty(ref _paratartalom, value); }
        }

        private DateTime _idopont;
        public DateTime Idopont
        {
            get { return _idopont; }
            set { SetProperty(ref _idopont, value); }
        }

        private async Task LoadDataAsync()
        {
            Idojaras model = await repository.GetValueAsync();
            Helyszin = model.Location.Name;
            KepLink = "https:" + model.Current.Condition.Icon;
            Celsius = model.Current.Temp_C;
            Paratartalom = model.Current.Humidity;
            Szelsebesseg = model.Current.Wind_Kph;
            Idopont = DateTime.Parse(model.Current.Last_Updated);
        }
    }
}
