using Microsoft.Maui.Platform;
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Windows.ApplicationModel.Core;
using WinRT;
using WinRT.Interop;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ChatGPT.WinUI;

/// <summary>
/// Provides application-specific behavior to supplement the default Application class.
/// </summary>
public partial class App : MauiWinUIApplication
{
    private AppWindow m_AppWindow;
    /// <summary>
    /// Initializes the singleton application object.  This is the first line of authored code
    /// executed, and as such is the logical equivalent of main() or WinMain().
    /// </summary>
    public App()
	{
		this.InitializeComponent();
        

        //AppWindow.FromAbi(IntPtr.Zero).TitleBar.ForegroundColor = Windows.UI.Color.FromArgb(0,55,55,55);

    }
    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        base.OnLaunched(args);
        //m_AppWindow = GetAppWindowForCurrentWindow();

        //m_AppWindow.Title = "App title";
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    private AppWindow GetAppWindowForCurrentWindow()
    {
        IntPtr hWnd = WindowNative.GetWindowHandle(Application.Handler);
        WindowId wndId = Win32Interop.GetWindowIdFromWindow(hWnd);
        return AppWindow.GetFromWindowId(wndId);
    }
    private void RefreshButton_Click(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }
}

