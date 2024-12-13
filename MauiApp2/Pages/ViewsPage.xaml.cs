namespace MauiApp2.Pages;

public partial class ViewsPage : ContentPage
{
	public ViewsPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		System.Diagnostics.Debug.WriteLine("Hello World");
		DisplayAlert("Alert","สวัสดี","ปิด");
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
    }
}