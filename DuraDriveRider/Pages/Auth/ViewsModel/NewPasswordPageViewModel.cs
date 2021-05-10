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
   public class NewPasswordPageViewModel : BaseViewModel
    {
        public ICommand SaveCommand => new Command(async (obj) =>
        {
            await RichNavigation.PushAsync(new LoginPage(), typeof(LoginPage));
        });
    }
}
