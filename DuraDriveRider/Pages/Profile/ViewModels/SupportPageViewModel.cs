using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.Views;
using DuraDriveRider.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.Profile.ViewModels
{
   public class SupportPageViewModel : BaseViewModel
    {
        public ICommand ChatSupportCommand => new Command(async (obj) =>
        {
            await RichNavigation.PushAsync(new ChatSupportPage(), typeof(ChatSupportPage));
        });
    }
}
