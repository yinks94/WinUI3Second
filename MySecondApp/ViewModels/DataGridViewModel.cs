using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using MySecondApp.Contracts.ViewModels;
using MySecondApp.Core.Contracts.Services;
using MySecondApp.Core.Models;

namespace MySecondApp.ViewModels;

//https://docs.devexpress.com/WinUI/403825/controls/data-grid/get-started/lesson-1-add-a-grid-control-to-your-project

public partial class DataGridViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<Product> Source { get; } = new ObservableCollection<Product>();

    public IList<string> Countries { private set; get; } = new List<string>();

    public DataGridViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();
        var data = await _sampleDataService.GetProductAsync();
        foreach (var product in data)
            Source.Add(product);

        Countries.Clear();
        var countries = data.Select(p => p.Country);
        Countries = countries.Distinct().ToList();
    }

    public void OnNavigatedFrom()
    {
    }
}
