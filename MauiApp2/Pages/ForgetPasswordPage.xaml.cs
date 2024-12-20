namespace MauiApp2.Pages;

//Annotation
//Receiving Data
[QueryProperty(nameof(Uname),"uname")]
[QueryProperty(nameof(Password),"pwd")]
[QueryProperty(nameof(LoginObj),"data")]

public partial class ForgetPasswordPage : ContentPage
{
	// public String uname = "";

	
	public String Uname { get; set; }
	public String Password { get; set; }

	public LoginData LoginObj { get; set; } = new LoginData();

	public ForgetPasswordPage()
	{
		InitializeComponent();
		
	}

	 private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }

		 private async void Button_Clicked1(object sender, EventArgs e)
    {
		System.Diagnostics.Debug.WriteLine("Username: ="+Uname);
		System.Diagnostics.Debug.WriteLine("Password: ="+Password);
		System.Diagnostics.Debug.WriteLine("Obj Username: ="+LoginObj.Uname);
		System.Diagnostics.Debug.WriteLine("Obj Password: ="+LoginObj.Password);
    }
}