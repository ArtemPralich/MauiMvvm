using MauiMvvm.View;

namespace MauiMvvm;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(EmployeeView), typeof(EmployeeView));
	}
}
