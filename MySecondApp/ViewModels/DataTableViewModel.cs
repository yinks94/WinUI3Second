using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using MySecondApp.Contracts.ViewModels;
using MySecondApp.Core.Contracts.Services;
using MySecondApp.Core.Models;

namespace MySecondApp.ViewModels;

public partial class DataTableViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public DataTableViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetGridDataAsync();

        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
