namespace MauiApp1.Views;

#pragma warning disable RMSEncoding01 // Codificação (Encoding) do arquivo
public partial class AboutPage : ContentPage
#pragma warning restore RMSEncoding01 // Codificação (Encoding) do arquivo
{
	public AboutPage()
	{
		InitializeComponent();
	}

  private async void LearnMore_Clicked(object sender, EventArgs e)
  {
    if (BindingContext is Models.About about)
    {
      // Navigate to the specified URL in the system browser.
      await Launcher.Default.OpenAsync(about.MoreInfoUrl);
    }
  }
}