using Microsoft.UI.Xaml.Controls;

using MySecondApp.ViewModels;

namespace MySecondApp.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
