using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.Auth.Views;
using DuraDriveRider.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.Auth.ViewsModel
{
   public class OTPpageViewModel : BaseViewModel
    {
        private bool openPersonalInfo;
        public ICommand DoneCommand { get; }
        public ICommand ResendOTPCommand { get; }
        public OTPpageViewModel(bool openPersonalInfo)
        {
            this.openPersonalInfo = openPersonalInfo;
            if(openPersonalInfo)
            {
                DoneCommand = CommandFactory.Create(Done);
            }
            else
            {
                DoneCommand = CommandFactory.Create(PersonalInfo);
            }
            ResendOTPCommand = CommandFactory.Create(ResendOTP);
        }
        async Task Done()
        {
            await RichNavigation.PushAsync(new NewPasswordPage(), typeof(NewPasswordPage));
        } 
        async Task PersonalInfo()
        {
            await RichNavigation.PushAsync(new PersonalInfoPage(), typeof(PersonalInfoPage));
        } 
        async Task ResendOTP()
        {
           // await RichNavigation.PushAsync(new PersonalInfoPage(), typeof(PersonalInfoPage));
        } 
    }
}
