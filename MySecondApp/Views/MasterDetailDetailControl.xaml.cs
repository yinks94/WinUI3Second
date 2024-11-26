using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using MySecondApp.Core.Models;

namespace MySecondApp.Views;

public sealed partial class MasterDetailDetailControl : UserControl
{
    public SampleOrder? ListDetailsMenuItem
    {
        get => GetValue(ListDetailsMenuItemProperty) as SampleOrder;
        set => SetValue(ListDetailsMenuItemProperty, value);
    }

    public static readonly DependencyProperty ListDetailsMenuItemProperty = DependencyProperty.Register("ListDetailsMenuItem", typeof(SampleOrder), typeof(MasterDetailDetailControl), new PropertyMetadata(null, OnListDetailsMenuItemPropertyChanged));

    public MasterDetailDetailControl()
    {
        InitializeComponent();
    }

    private static void OnListDetailsMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is MasterDetailDetailControl control)
        {
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
