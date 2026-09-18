using FanchantPractice.App.ViewModels;
namespace FanchantPractice.App.Views;
public partial class HomePage : ContentPage
{
    public HomePage() : this(IPlatformApplication.Current!.Services.GetRequiredService<HomeViewModel>()) { }
    public HomePage(HomeViewModel viewModel) { InitializeComponent(); BindingContext = viewModel; }
}
