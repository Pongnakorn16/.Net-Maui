using System;
using CommunityToolkit.Mvvm.ComponentModel;
 using CommunityToolkit.Mvvm.Input;
using MauiMiniProject.Pages;


namespace MauiMiniProject.ViewModel;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    string username = "";

    [ObservableProperty]
    
    string password = "";

    [ObservableProperty]
    string register = nameof(RegisterPage);
    
    [RelayCommand]
    async Task Login(){
        System.Diagnostics.Debug.WriteLine($"Username: {Username}");
        System.Diagnostics.Debug.WriteLine($"Password: {Password}");
        await GoToPage(nameof(HomePage));
    }

    //Task => Future (in flutter)
    [RelayCommand]
    async Task GoToPage(string page){
      await Shell.Current.GoToAsync(page);
    }
}
