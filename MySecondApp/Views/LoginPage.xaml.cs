using Microsoft.UI.Xaml.Controls;

using MySecondApp.ViewModels;

namespace MySecondApp.Views;

public sealed partial class LoginPage : Page
{
    public LoginViewModel ViewModel
    {
        get;
    }

    public LoginPage()
    {
        ViewModel = App.GetService<LoginViewModel>();
        InitializeComponent();
    }
}
