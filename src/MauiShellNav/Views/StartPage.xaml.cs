using MauiShellNav.ViewModels;

namespace MauiShellNav.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
		BindingContext = new StartPageViewModel();
	}
}