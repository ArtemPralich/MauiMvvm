using MauiMvvm.Model;
using MauiMvvm.ViewModel;

namespace MauiMvvm.View
{
	[QueryProperty(nameof(CompanyDetail), "CompanyDetail")]
	public class EmployeeViewModel : BaseViewModel
	{
		private Company _company;
		public Company CompanyDetail
		{
			get
			{
				return _company;
			}
			set
			{
				
				_company = value;
				OnPropertyChanged(nameof(CompanyDetail));
            }
		}
	}
}
