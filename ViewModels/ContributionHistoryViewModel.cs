using CommunityToolkit.Mvvm.ComponentModel;
using ImfuyoSync.Models;
using ImfuyoSync.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ImfuyoSync.ViewModels
{
    [QueryProperty(nameof(Contributor), "Contributor")]
    public partial class ContributionHistoryViewModel : ObservableObject
    {
        private readonly ContributorApiService _api;

        [ObservableProperty]
        private Contributor contributor;

        [ObservableProperty]
        private ObservableCollection<ContributionRecord> records;

        public ContributionHistoryViewModel(ContributorApiService api)
        {
            _api = api;
        }

        public async void OnAppearing()
        {
            var list = await _api.GetHistoryAsync(Contributor.Id);
            Records = new ObservableCollection<ContributionRecord>(list);
        }
    }

}
