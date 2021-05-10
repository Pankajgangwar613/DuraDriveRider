using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.Auth.Views;
using DuraDriveRider.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.Auth.ViewsModel
{
    public class RegisterPageViewModel : BaseViewModel
    {
        public ObservableCollection<string> CountryCodeList { get; set; } = new ObservableCollection<string>
        {
            "+ 63","+ 91"
        };
        public RegisterPageViewModel()
        {

        }
        public ICommand RegisterCommand => new Command(async (obj) =>
        {
            bool OpenPersonalInfo = false;
            await RichNavigation.PushAsync(new OTPpage(OpenPersonalInfo), typeof(OTPpage));
        });
    }
}
