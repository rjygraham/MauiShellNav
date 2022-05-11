using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiShellNav.Views;

namespace MauiShellNav.ViewModels;

[INotifyPropertyChanged]
public partial class StartPageViewModel
{
    [ICommand]
    private async Task GoToLogin()
    {
        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
}
