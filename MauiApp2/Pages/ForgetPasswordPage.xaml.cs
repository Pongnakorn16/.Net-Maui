namespace MauiApp2.Pages;

//Annotation
//Receiving Data
[QueryProperty(nameof(Uname),"uname")]
[QueryProperty(nameof(Password),"pwd")]

public partial class ForgetPasswordPage : ContentPage
{
	// public String uname = "";

	
	public String Uname { get; set; }
	public String Password { get; set; }

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
		System.Diagnostics.Debug.WriteLine(Uname);
		System.Diagnostics.Debug.WriteLine(Password);
    }
}