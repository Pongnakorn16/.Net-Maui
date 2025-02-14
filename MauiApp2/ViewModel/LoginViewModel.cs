using System;
using CommunityToolkit.Mvvm.ComponentModel;
 using CommunityToolkit.Mvvm.Input;
using MauiApp2.Pages;


namespace MauiApp2.ViewModel;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    string username = "";

    [ObservableProperty]
    
    string password = "";

    [ObservableProperty]
    string route = nameof(RegisterPage);
    
    [RelayCommand]
    async Task Login(){
        System.Diagnostics.Debug.WriteLine($"Username: {Username}");
        System.Diagnostics.Debug.WriteLine($"Password: {Password}");
        await GoToPage(nameof(ShowObjectsPage));
    }

    //Task => Future (in flutter)
    [RelayCommand]
    async Task GoToPage(string page){
      await Shell.Current.GoToAsync(page);
    }
}
