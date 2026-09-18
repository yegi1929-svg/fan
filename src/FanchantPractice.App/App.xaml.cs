using Microsoft.Extensions.DependencyInjection;

using FanchantPractice.App.Services.Interfaces;

namespace FanchantPractice.App;

public partial class App : Application
{
	private readonly IDatabaseInitializer _databaseInitializer;

	public App(IDatabaseInitializer databaseInitializer)
	{
		InitializeComponent();
		_databaseInitializer = databaseInitializer;
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}

	protected override async void OnStart()
	{
		base.OnStart();
		await _databaseInitializer.InitializeAsync();
	}
}
