using MauiApp2.ViewModel;

namespace MauiApp2.Pages;

public partial class ShowDataPage : ContentPage
{
	public ShowDataPage()
	{
		InitializeComponent();
		BindingContext = new ShowDataViewModel();
	}
}