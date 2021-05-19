using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.XctTabView.Views;
using DuraDriveRider.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.XctTabView.ViewModels
{
   public class ReachedLocationPageViewModel : BaseViewModel
    {
        public ICommand ValidateCommand => new Command(async (obj) =>
        {
            await RichNavigation.PushAsync(new ReachedPickupLocationPage("VerifyItems"), typeof(ReachedPickupLocationPage));
        });
        public ICommand ReachedDropoffLocatioCommand => new Command(async (obj) =>
        {
            await RichNavigation.PushAsync(new ReachedPickupLocationPage("DeliveryStatus"), typeof(ReachedPickupLocationPage));
        });
    }
}
