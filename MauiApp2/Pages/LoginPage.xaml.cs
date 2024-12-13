namespace MauiApp2.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine(uname.Text);
        System.Diagnostics.Debug.WriteLine(pwd.Text);
        if (uname.Text == "admin" && pwd.Text == "1234")
        {
            await Navigation.PushAsync(new ViewsPage());
        }
        else
        {
            DisplayAlert("Error", "Username or Password Incorrect", "Try again");
        }
    }

	private async void ForgetPasswordTapped(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("forgetpassword");
	}
}