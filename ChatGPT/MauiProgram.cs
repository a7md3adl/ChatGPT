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

		return builder.Build();
	}
}
