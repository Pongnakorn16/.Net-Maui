namespace MauiApp2.Pages;

public partial class ForgetPasswordPage : ContentPage
{
	public ForgetPasswordPage()
	{
		InitializeComponent();
	}

	 private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}