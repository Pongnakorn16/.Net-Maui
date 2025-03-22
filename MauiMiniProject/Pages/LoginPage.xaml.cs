using MauiMiniProject.ViewModel;

namespace MauiMiniProject.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel();
	}

    // public class LoginData
    // {
    // 	public String Uname { get; set; } = "";
    // 	public String Password { get; set; } = "";
    // }
}