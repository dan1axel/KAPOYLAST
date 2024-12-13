using Microsoft.Maui.Controls;
using System;

namespace SpeechSecuritySystem
{
    public partial class AdminDashboard : ContentPage
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private async void OnNavigationButtonClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Reset all buttons to default style
                DashboardButton.Style = (Style)Resources["SidebarButtonStyle"];

                // Set the clicked button to active style
                button.Style = (Style)Resources["ActiveSidebarButtonStyle"];

                // Navigate based on the button clicked
                switch (button.Text)
                {
                    case "Dashboard":
                        await Navigation.PushAsync(new DashboardPage());
                        break;
                }
            }
        }

        private async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LandingPage());
        }

        private async void OnFolderImageTapped(object sender, EventArgs e)
        {
            // Navigate to the FolderPage when the image is tapped
            await Navigation.PushAsync(new FailedAttempts());
        }


    }
}
