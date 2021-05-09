using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.Auth.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.Auth.ViewsModel
{
   public class LoginPageViewModel
    {
        public ObservableCollection<string> LoginList { get; set; } = new ObservableCollection<string>
        {
            "hi, John","no name"
        };
        public ICommand LoginCommand => new Command(async (obj) =>
        {
            await RichNavigation.PushAsync(new ForgotPasswordPage(), typeof(ForgotPasswordPage));
        });
        public ICommand RegisterCommand => new Command(async (obj) =>
        {
            await RichNavigation.PushAsync(new ForgotPasswordPage(), typeof(ForgotPasswordPage));
        });
    }
}
