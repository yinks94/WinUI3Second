using Microsoft.UI.Xaml.Controls;

using MySecondApp.ViewModels;

namespace MySecondApp.Views;

// TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
// For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
public sealed partial class DataTablePage : Page
{
    public DataTableViewModel ViewModel
    {
        get;
    }

    public DataTablePage()
    {
        ViewModel = App.GetService<DataTableViewModel>();
        InitializeComponent();
    }
}
