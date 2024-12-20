using System;
using CommunityToolkit.Mvvm.ComponentModel;
 using CommunityToolkit.Mvvm.Input;


namespace MauiApp2.VeiwModel;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    string username = "";

    [ObservableProperty]
    string password = "";
}
