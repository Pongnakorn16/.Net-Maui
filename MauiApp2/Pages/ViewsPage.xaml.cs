namespace MauiApp2.Pages;

public partial class ViewsPage : ContentPage
{
	public ViewsPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
		// System.Diagnostics.Debug.WriteLine("Hello World");
		// DisplayAlert("Alert","สวัสดี","ปิด");
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
    }
}