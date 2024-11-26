using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Net.Sockets;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using MySecondApp.Contracts.Services;
using MySecondApp.Views;

namespace MySecondApp.ViewModels;

public partial class LoginViewModel : ObservableRecipient
{
    private readonly ILogger<LoginViewModel> _logger;
    private readonly ISessionService _sessionService;

    public LoginViewModel(
        ISessionService sessionService,
        ILogger<LoginViewModel> logger)
    {
        _sessionService = sessionService;
        _logger = logger;
    }

    private long acceptCount = 0;

    [ObservableProperty]
    private string? loginId = string.Empty;

    [ObservableProperty]
    private string? password = string.Empty;

    [RelayCommand]
    private void LoginUser()
    {
        if( LoginId.Equals("aaaa") && Password.Equals("aaaa"))
        {
            
            Debug.WriteLine("로그인 성공");
            _sessionService.SetSessionUser(new Models.Member("aaaa"));
            App.MainWindow.Content = App.GetService<ShellPage>();
            App.MainWindow.SetWindowSize(1204, 900);
            App.MainWindow.IsMaximizable = true;
            App.MainWindow.CenterOnScreen();
        }
        else
        {
            acceptCount++;
            if (acceptCount >= 5)
            {
                _logger.LogInformation($"Login in failed from {LoginId}");
                App.MainWindow.Close();
            }
            else
            {
                Debug.WriteLine($"AcceptCount is {acceptCount}");
                OnPropertyChanged(nameof(LoginButtonText));
            }
        }
    }

    public string LoginButtonText => acceptCount == 0 ? "로그인" : string.Format("로그인({0})", acceptCount);
}
