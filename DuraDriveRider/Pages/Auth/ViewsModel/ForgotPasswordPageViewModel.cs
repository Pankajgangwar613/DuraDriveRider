using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.Auth.Views;
using DuraDriveRider.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.Auth.ViewsModel
{
   public class ForgotPasswordPageViewModel: BaseViewModel
    {
        public ICommand GetOtpCommand => new Command(async (obj) =>
        {
            bool OpenPersonalInfo = true;
            await RichNavigation.PushAsync(new OTPpage(OpenPersonalInfo), typeof(OTPpage));
        });
    }
}
