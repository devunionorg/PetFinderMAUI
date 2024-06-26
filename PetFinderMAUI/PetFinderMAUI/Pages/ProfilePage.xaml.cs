using PetFinderMAUI.ViewModels;

namespace PetFinderMAUI.Pages;

public partial class ProfilePage : ContentPage
{
    
    public ProfilePage()
    {
        InitializeComponent();
       
    }

    private void OnLogoutClicked(object sender, EventArgs e)
    {
        // Clear the user's credentials from secure storage
        SecureStorage.Remove("username");
        SecureStorage.Remove("password");

        // Update the user's login status
        Preferences.Set("IsLoggedIn", false);

        // Navigate to the login page
        // await Navigation.PushAsync(new LoginPage());
        // Set the HomePage of the application to a new instance of LoginPage
        Application.Current!.MainPage = new LoginPage();
    }

    private async void OnManagePostsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SettingsPage());
    }
}