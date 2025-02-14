using MauiApp2.Pages;

namespace MauiApp2;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ForgetPasswordPage), typeof(ForgetPasswordPage));
		Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
		Routing.RegisterRoute(nameof(ShowDataPage), typeof(ShowDataPage));
		Routing.RegisterRoute(nameof(ShowObjectsPage), typeof(ShowObjectsPage));
	}
}
