namespace LubeLogger_Companion_App
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSettingsBtnClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//SettingsPage/");
        }
    }
}