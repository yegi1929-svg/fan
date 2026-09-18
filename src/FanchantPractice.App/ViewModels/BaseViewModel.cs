using CommunityToolkit.Mvvm.ComponentModel;
namespace FanchantPractice.App.ViewModels;
public abstract partial class BaseViewModel : ObservableObject
{
    [ObservableProperty] private bool isBusy;
    [ObservableProperty] private string? errorMessage;
    public bool HasError => !string.IsNullOrWhiteSpace(ErrorMessage);
}
