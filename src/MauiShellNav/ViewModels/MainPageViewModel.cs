using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiShellNav.Views;

namespace MauiShellNav.ViewModels;

[INotifyPropertyChanged]
public partial class MainPageViewModel
{
    [ICommand]
    private async Task Logout()
    {
        await Shell.Current.GoToAsync($"//{nameof(StartPage)}");
    }
}
