using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
namespace FanchantPractice.App.ViewModels;
public partial class HomeViewModel : BaseViewModel
{
    public string Greeting => "오늘도 응원 준비하기";
    public ObservableCollection<string> Members { get; } = ["윤두준", "양요섭", "이기광", "손동운"];
    [RelayCommand] private static Task StartPracticeAsync() => Shell.Current.GoToAsync("//songs");
}
