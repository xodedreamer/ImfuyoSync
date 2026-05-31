using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ImfuyoSync.Models;
using ImfuyoSync.Services;
using ImfuyoSync.Views.Contributors;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImfuyoSync.ViewModels
{
    [QueryProperty(nameof(Contributor), "Contributor")]
    public partial class ContributorDetailsViewModel : ObservableObject
    {
        private readonly ContributorApiService _api;

        [ObservableProperty]
        private Contributor contributor;

        public ContributorDetailsViewModel(ContributorApiService api)
        {
            _api = api;
        }

        [RelayCommand]
        private async Task AddContribution()
        {
            await Shell.Current.GoToAsync(nameof(AddContributionPage), true,
                new Dictionary<string, object> { { "Contributor", Contributor } });
        }

        [RelayCommand]
        private async Task AddReimbursement()
        {
            await Shell.Current.GoToAsync(nameof(AddReimbursementPage), true,
                new Dictionary<string, object> { { "Contributor", Contributor } });
        }

        [RelayCommand]
        private async Task ViewHistory()
        {
            await Shell.Current.GoToAsync(nameof(ContributionHistoryPage), true,
                new Dictionary<string, object> { { "Contributor", Contributor } });
        }
    }

}
