using ImfuyoSync.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

namespace ImfuyoSync.Services
{
    public class ContributorApiService
    {
        private readonly HttpClient _http;

        public ContributorApiService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Contributor>> GetContributorsAsync()
            => await _http.GetFromJsonAsync<List<Contributor>>("/contributors");

        public async Task<Contributor> AddContributorAsync(Contributor c)
        {
            var response = await _http.PostAsJsonAsync("/contributors", c);
            return await response.Content.ReadFromJsonAsync<Contributor>();
        }

        public async Task<ContributionRecord> AddContributionAsync(string contributorId, decimal amount)
        {
            var response = await _http.PostAsJsonAsync($"/contributors/{contributorId}/contribute", amount);
            return await response.Content.ReadFromJsonAsync<ContributionRecord>();
        }

        public async Task<ContributionRecord> AddReimbursementAsync(string contributorId, decimal amount)
        {
            var response = await _http.PostAsJsonAsync($"/contributors/{contributorId}/reimburse", amount);
            return await response.Content.ReadFromJsonAsync<ContributionRecord>();
        }

        public async Task<List<ContributionRecord>> GetHistoryAsync(string contributorId)
            => await _http.GetFromJsonAsync<List<ContributionRecord>>($"/contributors/{contributorId}/history");
    }

}
