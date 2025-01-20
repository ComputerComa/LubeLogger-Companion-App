using Windows.UI.Input;

namespace LubeLogger_Companion_App
{
    public partial class AppShell : Shell
    {
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await app.SystemControl();
        }
        public AppShell()
        {
            InitializeComponent();
        }

        
}
