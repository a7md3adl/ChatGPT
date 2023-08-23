using System.Diagnostics;

namespace ChatGPT;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        this.Navigated += AppShell_Navigated;
		
	}

    private void AppShell_Navigated(object sender, ShellNavigatedEventArgs e)
    {
        var location = e.Current.Location.ToString().Replace("//","");
        switch (location.ToLower()) {
            case "mainpage": Window.Title = "ChatGPT";break;
            case "bard": Window.Title = "Bard";  Application.Current.MainPage.IconImageSource = ImageSource.FromResource("ChatGPT\\Resources\\Images\\gbard.png");
                break;
            case "youtube": Window.Title = "YouTube"; break;
            case "google": Window.Title = "Google"; break;
            case "github": Window.Title = "github"; break;

            default: Window.Title = "ChatGPT"; break;
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
       
    }
}
