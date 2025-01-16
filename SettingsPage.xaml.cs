using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace LubeLogger_Companion_App;


public partial class SettingsPage : ContentPage
{
    bool showPassword = false;
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
            ShowPassword.Source = "eye_off.svg";
        }
        else
        {
            ShowPassword.Source = "eye.svg";
            
        }

        

    }

    private void loadPreferences()
    {

    }

    private async void SaveAppPreferences(string url,string username,string password)
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