using DuraDriveRider.Infrastructure;
using DuraDriveRider.Pages.XctTabView.PopUp;
using DuraDriveRider.Pages.XctTabView.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuraDriveRider.Pages.XctTabView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReachedPickupLocationPage : BaseContentPage
    {
        public ReachedPickupLocationPage(String PageTitle)
        { 
            InitializeComponent();
            BindingContext = new ReachedPickupLocationPageViewModel();
            if (PageTitle == "VerifyItems")
            {
                StkVerifyItems.IsVisible = true;
                StkPaymentStatus.IsVisible = false;
            }
            else if (PageTitle == "DeliveryStatus")
            {
                StkPaymentStatus.IsVisible = true;
                StkVerifyItems.IsVisible = false;
            }
            else
            {
                StkVerifyItems.IsVisible = true;
                StkPaymentStatus.IsVisible = false;
            }
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new DeclinePopUp("CancelPopup")); 
        }

        private void DeliveryNotDone_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new DeclinePopUp("RejectPopup"));
        }

        private void CollectPayment_Clicked(object sender, EventArgs e)
        { 
            Navigation.ShowPopup(new PaymentCollectedPopup());
        }
    }
}