using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using System.Globalization;
using Application = Microsoft.Maui.Controls.Application;
using WebView = Microsoft.Maui.Controls.WebView;

namespace ChatGPT;

public partial class Google : ContentPage
{
	int count = 0;
    Uri appuri = new Uri("https://www.google.com/");
	public Google()
	{
        InitializeComponent();
        //webView.IsVisible = false;

        //webView.On<Windows>().SetIsJavaScriptAlertEnabled(false);

        //      webView.On<Windows>().SetIsLegacyColorModeEnabled(true);
        //      webView.On<Windows>().SetExecutionMode(WebViewExecutionMode.SeparateThread);
       // webView.Source = "https://chat.openai.com/";
        webView.Navigated += WebView_Navigated;
        webView.Loaded += WebView_Loaded;
        webView.Navigating += WebView_Navigating;   
        //Window.Page.IconImageSource = ImageSource.FromFile("ChatGPT.png");

    }

    private void WebView_Loaded(object sender, EventArgs e)
    {
        //if(webView.Source == "https://chat.openai.com/")

        //webView.IsVisible = true;

    }

    private void WebView_Navigating(object sender, WebNavigatingEventArgs e)
    {
        
    }
    bool err = false;
    private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
    {

        if (e.Url == "https://google.com/")
        {
            if (e.Result == WebNavigationResult.Failure || e.Result == WebNavigationResult.Timeout)
            {
                err = true;
                string htmlContent = "<html><head><style>"
                                                + "body { font-family: Arial, sans-serif; background-color: #343541; text-align: center; margin: 0; padding: 50px; color: #ffffff; }"
                                                + "h1 { color: #ffffff; }"
                                                + "</style></head><body>"
                                                + "<h1>Could not connect to server.</h1>"
                                                + "<p>Please check you internet connection and try again.</p>"
                                                + "</body></html>";
                webView.Source = new HtmlWebViewSource { Html = htmlContent };


            }
        }
       


    }


    private void SignInButton_Clicked(object sender, EventArgs e)
	{
		//count++;

		//if (count == 1)
		//	CounterBtn.Text = $"Clicked {count} time";
		//else
		//	CounterBtn.Text = $"Clicked {count} times";

		//SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

