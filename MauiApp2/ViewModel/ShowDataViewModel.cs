using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp2.ViewModel;

public partial class ShowDataViewModel : ObservableObject
{
    [ObservableProperty]

    ObservableCollection<string> listData = ["One", "Two", "Three", "Four", "Five"];

    [ObservableProperty]
    string itemText = "";

    [RelayCommand]

    void Add(string item){
        ListData.Add(item);
    }
}
