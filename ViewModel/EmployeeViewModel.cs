using MauiMvvm.ViewModel;

namespace MauiMvvm.View
{
	[QueryProperty("Company", "Company")]
	internal class EmployeeViewModel : BaseViewModel
	{
		CompanyView _company { get; set; }
	}
}
