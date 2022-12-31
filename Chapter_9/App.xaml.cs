using Chapter_9.ModelView.DependencyInjectionExtention;

namespace Chapter_9;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		DependencyInjectionExtention.Init();
		MainPage = new AppShell();
	}
}
