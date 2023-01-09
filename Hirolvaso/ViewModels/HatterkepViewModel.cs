﻿using CommunityToolkit.Mvvm.ComponentModel;
using Hirolvaso.Models;
using Hirolvaso.Repositories;

namespace Hirolvaso.ViewModels
{
    public class HatterkepViewModel : ObservableObject
    {
        private const string URL_BASE = "https://www.bing.com/";
        private const string DESKTOP_RESOLUTION = "_1920x1080.jpg";
        private const string MOBILE_RESOLUTION = "_720x1280.jpg";
        private readonly GenericAPIRepository<Hatterkep> repository;

        public HatterkepViewModel()
        {
            repository = new GenericAPIRepository<Hatterkep>(OldalTipus.Hatterkep);
            LoadDataAsync();
            //Task.Run(async () =>
            //    await LoadDataAsync());
        }

        private string kepLink;
        public string KepLink
        {
            get { return kepLink; }
            set { SetProperty(ref kepLink, value); }
        }

        private string szerzoiJog;
        public string SzerzoiJog
        {
            get { return szerzoiJog; }
            set { SetProperty(ref szerzoiJog, value); }
        }

        private string cim;
        public string Cim
        {
            get { return cim; }
            set { SetProperty(ref cim, value); }
        }

        private async Task LoadDataAsync()
        {
            Hatterkep model = await repository.GetValueAsync();
            Kep kep = model.Images.First();
            if (DeviceInfo.Current.Idiom == DeviceIdiom.Desktop)
            {
                KepLink = URL_BASE + kep.UrlBase + DESKTOP_RESOLUTION;
            }
            // Ha mobilon nyitják meg
            else if (DeviceInfo.Current.Idiom == DeviceIdiom.Phone)
            {
                KepLink = URL_BASE + kep.UrlBase + MOBILE_RESOLUTION;
            }
            // string resolution = $"_{DeviceDisplay.Current.MainDisplayInfo.Width}x{DeviceDisplay.Current.MainDisplayInfo.Height}.jpg";
            // KepLink = URL_BASE + kep.Urlbase + felbontas;
            SzerzoiJog = model.Images.First().Ccopyright;
            Cim = model.Images.First().Title;
        }
    }
}
