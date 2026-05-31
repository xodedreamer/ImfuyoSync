using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ImfuyoSync.Models;
using ImfuyoSync.Services;
using ImfuyoSync.Views.Contributors;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ImfuyoSync.ViewModels
{
    public partial class ContributorListViewModel : ObservableObject
    {
        private readonly ContributorApiService _api;

        [ObservableProperty]
        private ObservableCollection<Contributor> contributors;

        public ContributorListViewModel(ContributorApiService api)
        {
            _api = api;
            LoadContributors();
        }

        private async void LoadContributors()
        {
            var list = await _api.GetContributorsAsync();
            Contributors = new ObservableCollection<Contributor>(list);
        }

        [RelayCommand]
        private async Task OpenDetails(Contributor contributor)
        {
            await Shell.Current.GoToAsync(nameof(ContributorDetailsPage), true,
                new Dictionary<string, object> { { "Contributor", contributor } });
        }
    }

}
