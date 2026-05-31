using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ImfuyoSync.Models;
using ImfuyoSync.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImfuyoSync.ViewModels
{
    [QueryProperty(nameof(Contributor), "Contributor")]
    public partial class AddContributionViewModel : ObservableObject
    {
        private readonly ContributorApiService _api;

        [ObservableProperty]
        private Contributor contributor;

        [ObservableProperty]
        private decimal amount;

        public AddContributionViewModel(ContributorApiService api)
        {
            _api = api;
        }

        [RelayCommand]
        private async Task Save()
        {
            await _api.AddContributionAsync(Contributor.Id, Amount);
            await Shell.Current.GoToAsync("..");
        }
    }

}
