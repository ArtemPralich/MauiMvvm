namespace MauiMvvm.View;

public partial class EmployeeView : ContentPage
{
	public EmployeeView()
	{
		InitializeComponent();
		this.BindingContext = new EmployeeViewModel();
	}
}