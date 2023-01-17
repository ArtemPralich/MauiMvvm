using MauiMvvm.ViewModel;

namespace MauiMvvm.View;

public partial class CompanyView : ContentPage
{
	public CompanyView()
	{
		InitializeComponent();
		this.BindingContext = new CompanyViewModel();
	}
}