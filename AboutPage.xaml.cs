using System.Windows.Input;

namespace LubeLogger_Companion_App;

public partial class AboutPage : ContentPage
{
    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
    public AboutPage()
	{
		InitializeComponent();
		BindingContext = this;
	}



    private void Bug_Report_Clicked(object sender, EventArgs e)
    {
        Launcher.OpenAsync("https://github.com/ComputerComa/LubeLogger-Companion-App/issues/new?template=Blank+issue");
    }
}