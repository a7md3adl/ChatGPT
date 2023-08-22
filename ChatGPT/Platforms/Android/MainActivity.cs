using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace ChatGPT;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    [Obsolete]
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        if (Build.VERSION.SdkInt >= BuildVersionCodes.Kitkat)
        {
            Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#343541"));
            Window.SetNavigationBarColor(Android.Graphics.Color.ParseColor("#343541"));
            var s = SystemUiFlags.LayoutFullscreen | SystemUiFlags.LayoutStable;
            FindViewById(Android.Resource.Id.Content).SystemUiVisibility = (StatusBarVisibility)s;
           

        }

    }
}
