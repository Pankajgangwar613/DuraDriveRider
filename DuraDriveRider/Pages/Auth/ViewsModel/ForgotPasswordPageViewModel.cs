using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.Auth.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.Auth.ViewsModel
{
    class ForgotPasswordPageViewModel
    {
        public ICommand LoginCommand => new Command(async (obj) =>
        {
            await RichNavigation.PushAsync(new ForgotPasswordPage(), typeof(ForgotPasswordPage));
        });
    }
}
