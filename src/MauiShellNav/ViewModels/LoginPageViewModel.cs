using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiShellNav.Views;

namespace MauiShellNav.ViewModels;

[INotifyPropertyChanged]
public partial class LoginPageViewModel
{
    [ICommand(CanExecute = nameof(AlwaysCanGoBack))]
    private async Task Back()
    {
        await Shell.Current.GoToAsync("..");
    }

    public bool AlwaysCanGoBack { get; init; } = true;

    [ICommand]
    private async Task Login()
    {
        await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }
}
