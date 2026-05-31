using ImfuyoSync.Views.Contributors;

namespace ImfuyoSync
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ContributorDetailsPage), typeof(ContributorDetailsPage));
            Routing.RegisterRoute(nameof(AddContributionPage), typeof(AddContributionPage));
            Routing.RegisterRoute(nameof(AddReimbursementPage), typeof(AddReimbursementPage));
            Routing.RegisterRoute(nameof(ContributionHistoryPage), typeof(ContributionHistoryPage));
        }
    }
}
