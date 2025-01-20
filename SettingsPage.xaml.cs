using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using Windows.Media.AppBroadcasting;


namespace LubeLogger_Companion_App;


public partial class SettingsPage : ContentPage
{
    bool showPassword = false;
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await loadPreferences();
    }

    public SettingsPage()
    {

        InitializeComponent();
    }
    private void TogglePassword()
    {


        ConnectionPassword.IsPassword = !showPassword;
        showPassword = !showPassword;
        if (showPassword)
        {
            ShowPassword.Source = ImageSource.FromFile("eye_off.png");
        }
        else
        {
            ShowPassword.Source = ImageSource.FromFile("eye.png");

        }



    }

    private async Task loadPreferences()
    {
        string? url = await SecureStorage.Default.GetAsync("connectionurl");
        string? username = await SecureStorage.Default.GetAsync("username");
        string? password = await SecureStorage.Default.GetAsync("password");
        if (url is not null & username is not null & password is not null)
        {
            ConnectionUrl.Text = url;
            ConnectionUsername.Text = username;
            ConnectionPassword.Text = password;
        }
    }


    private async void SaveAppPreferences(string url, string username, string password)
    {
        await SecureStorage.Default.SetAsync("connectionurl", url);
        await SecureStorage.Default.SetAsync("username", username);
        await SecureStorage.Default.SetAsync("password", password);


        var toast = Toast.Make("Settings have been Saved!", ToastDuration.Short, 14);
        await toast.Show(new CancellationTokenSource().Token);


    }

    private void SaveSettings_Clicked(object sender, EventArgs e)
    {
        SaveAppPreferences(ConnectionUrl.Text, ConnectionUsername.Text, ConnectionPassword.Text);
        
    }

    private void ShowPassword_Clicked(object sender, EventArgs e)
    {
        TogglePassword();
    }
}