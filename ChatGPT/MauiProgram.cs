using Microsoft.Maui.LifecycleEvents;
#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
#endif
namespace ChatGPT;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
        System.Threading.Thread.CurrentThread.CurrentCulture = culture;

        var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
       // AddTitleBarCodeOnWindows(builder, new System.Drawing.Size(1000,1000));
        
		return builder.Build();
	}
    public static void AddTitleBarCodeOnWindows(MauiAppBuilder builder, System.Drawing.Size size)
    {
#if WINDOWS
            builder.ConfigureLifecycleEvents(events =>
            {
                events.AddWindows(wndLifeCycleBuilder =>
                {
                    wndLifeCycleBuilder.OnWindowCreated(window =>
                    {
                        IntPtr nativeWindowHandle = WinRT.Interop.WindowNative.GetWindowHandle(window);
                        WindowId win32WindowsId = Win32Interop.GetWindowIdFromWindow(nativeWindowHandle);
                        AppWindow winuiAppWindow = AppWindow.GetFromWindowId(win32WindowsId);
                        if(winuiAppWindow.Presenter is OverlappedPresenter p)
                        {
                            window.ExtendsContentIntoTitleBar = false;
                            p.SetBorderAndTitleBar(false, false);
                        }
                        var containerForm = WinFormsLibrary1.Class1.CreateContainerForm(size.Width, size.Height);
                        containerForm.Enclose(nativeWindowHandle);
                        containerForm.TitleText = window.Title;
                        //Apparently necessary since app doesn't close on its own.
                        //I would have thought closing the form, and therefore destroying the child MAUI Window, would do the trick.
                        containerForm.FormClosedSimple += (sender, args) => Application.Current.Quit();
                    });
                });
            });
#endif
    }
}
