using MauiApp2.ViewModel;

namespace MauiApp2.Pages;

public partial class ShowObjectsPage : ContentPage
{
	public ShowObjectsPage()
	{
		InitializeComponent();
		BindingContext = new ShowObjectsViewModel();
	}
}