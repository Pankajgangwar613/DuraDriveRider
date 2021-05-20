using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.Views;
using DuraDriveRider.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.ViewModels
{
   public class GCashPageViewModel : BaseViewModel
    {
        public ICommand SubmitCommand => new Command(async (obj) =>
        {
            await RichNavigation.PushAsync(new SuccessfulPage(), typeof(SuccessfulPage));
        });
    }
}
