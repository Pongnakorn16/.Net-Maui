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
        var loginData = new LoginData {
            Uname = uname.Text,
            Password = pwd.Text
        };
        var queryParams = new Dictionary<String, object>{
            {"data",loginData}
        };

        System.Diagnostics.Debug.WriteLine($"forgetpassword?uname={uname.Text}&pwd={pwd.Text}");
        System.Diagnostics.Debug.WriteLine($"{nameof(ForgetPasswordPage)}?uname={uname.Text}&pwd={pwd.Text}");
        // await Shell.Current.GoToAsync($"forgetpassword?uname={uname.Text}&pwd={pwd.Text}");
        await Shell.Current.GoToAsync("forgetpassword", queryParams);

        //แบบ nameof ไม่รู้ทำไมใช้ไม่ได้
        // await Shell.Current.GoToAsync($"{nameof(ForgetPasswordPage)}?uname={uname.Text}&pwd={pwd.Text}");
        // await Shell.Current.GoToAsync($"{nameof(ForgetPasswordPage)}{queryParams}");
	}
}

 public class LoginData {
    public String Uname {get; set;} = "";
    public String Password {get; set;} = "";
}