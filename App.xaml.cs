namespace LubeLogger_Companion_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
        private async Task SystemControl()
        {
            string? url = await SecureStorage.Default.GetAsync("connectionurl");
            string? username = await SecureStorage.Default.GetAsync("username");
            string? password = await SecureStorage.Default.GetAsync("password");
            if (url is not null & username is not null & password is not null)
            {
                MainLoad(true);
            }
            else
            {
                MainLoad(false);
            }
        }

        public void MainLoad(bool settingsInitialized)
        {
            if (settingsInitialized)
            {
                
                HomeShellContent.IsVisible = false;
                OverviewShellContent.IsVisible = true;
                PlannerShellContent.IsVisible = true;
                OdometerShellContent.IsVisible = true;
                ServiceShellContent.IsVisible = true;
                RepairsShellContent.IsVisible = true;
                UpgradesShellContent.IsVisible = true;
                FuelingShellContent.IsVisible = true;
                SuppliesShellContent.IsVisible = true;
                TaxesShellContent.IsVisible = true;
                NotesShellContent.IsVisible = true;
                RemindersShellContent.IsVisible = true;
            }
            else
            {
                HomeShellContent.IsVisible = true;
                OverviewShellContent.IsVisible = false;
                PlannerShellContent.IsVisible = false;
                OdometerShellContent.IsVisible = false;
                ServiceShellContent.IsVisible = false;
                RepairsShellContent.IsVisible = false;
                UpgradesShellContent.IsVisible = false;
                FuelingShellContent.IsVisible = false;
                SuppliesShellContent.IsVisible = false;
                TaxesShellContent.IsVisible = false;
                NotesShellContent.IsVisible = false;
                RemindersShellContent.IsVisible = false;

            }

        }
    }

}
}