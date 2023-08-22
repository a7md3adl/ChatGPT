using Microsoft.Maui.Platform;
using Microsoft.UI.Xaml;
using Windows.ApplicationModel.Core;
using WinRT;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ChatGPT.WinUI;

/// <summary>
/// Provides application-specific behavior to supplement the default Application class.
/// </summary>
public partial class App : MauiWinUIApplication
{
	/// <summary>
	/// Initializes the singleton application object.  This is the first line of authored code
	/// executed, and as such is the logical equivalent of main() or WinMain().
	/// </summary>
	public App()
	{
		this.InitializeComponent();
        

    }

    
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    private void CustomizeTitleBar()
    {
        
       // Get the native title bar
       var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
        UIElement el = coreTitleBar.As<UIElement>();
        // Create a custom title bar template
        var customTitleBar = new Grid();
        customTitleBar.Background = new SolidColorBrush(Color.FromRgb(200,200,200));

        // Create your custom refresh button
        var refreshButton = new Button();
        refreshButton.Text = "Refresh";
        refreshButton.Clicked += RefreshButton_Click;

        // Add the refresh button to the custom title bar
        customTitleBar.Children.Add(refreshButton);

        // Set the custom title bar
        coreTitleBar.ExtendViewIntoTitleBar = true;
        CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
        Microsoft.UI.Xaml.Window.Current.SetTitleBar(el);
        
    }

    private void RefreshButton_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}

