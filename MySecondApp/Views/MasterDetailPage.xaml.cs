using CommunityToolkit.WinUI.UI.Controls;

using Microsoft.UI.Xaml.Controls;

using MySecondApp.ViewModels;

namespace MySecondApp.Views;

public sealed partial class MasterDetailPage : Page
{
    public MasterDetailViewModel ViewModel
    {
        get;
    }

    public MasterDetailPage()
    {
        ViewModel = App.GetService<MasterDetailViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
