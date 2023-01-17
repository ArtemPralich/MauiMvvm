namespace MauiMvvm.View;

public partial class EmployeeView : ContentPage
{
	public EmployeeView(EmployeeViewModel employeeViewModel)
	{
		InitializeComponent();
		this.BindingContext = employeeViewModel;
	}
}