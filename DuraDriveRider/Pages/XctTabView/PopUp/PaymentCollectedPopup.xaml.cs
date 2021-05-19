using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuraDriveRider.Pages.XctTabView.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentCollectedPopup 
    {
        public PaymentCollectedPopup()
        {
            InitializeComponent();
        }

        private async void ConfirmDelivery_Clicked(object sender, EventArgs e)
        {
            Dismiss(null);
            await RichNavigation.PushAsync(new ReviewPage(), typeof(ReviewPage));

        }
    }
}