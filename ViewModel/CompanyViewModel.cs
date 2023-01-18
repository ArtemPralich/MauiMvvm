using MauiMvvm.Model;
using MauiMvvm.View;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiMvvm.ViewModel
{
    internal class CompanyViewModel : BaseViewModel
    {
        public ObservableCollection<Company> Companies { get; set; } = new ObservableCollection<Company> { new Company() { Title = "ewrwe" }, new Company() { Title = "qwe123" }, };

        public CompanyViewModel()
        {
            SelectedCompanyCommand = new Command(OnSelectCompany);
        }
        public ICommand SelectedCompanyCommand { get; set; }

        async void OnSelectCompany(object company) {
            await Shell.Current.GoToAsync($"{nameof(EmployeeView)}", true, 
                new Dictionary<string, object> 
                { 
                    {
                        "CompanyDetail", company
                    } 
                });
        }
    }
}
