using Microsoft.UI.Xaml.Controls;

using MySecondApp.ViewModels;

namespace MySecondApp.Views;

public sealed partial class GridContentPage : Page
{
    public GridContentViewModel ViewModel
    {
        get;
    }

    public GridContentPage()
    {
        ViewModel = App.GetService<GridContentViewModel>();
        InitializeComponent();
    }
}
