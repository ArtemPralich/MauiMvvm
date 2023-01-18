using MauiMvvm.Model;

namespace MauiMvvm.View;

[QueryProperty("Company", "Company")]
public partial class EmployeeView : ContentPage
{
	public EmployeeView(EmployeeViewModel employeeViewModel) 
	{
		InitializeComponent();
		this.BindingContext = employeeViewModel;
	}

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}
}