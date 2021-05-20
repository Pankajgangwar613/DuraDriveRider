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
    public partial class AmountPopup  
    {
        public AmountPopup()
        {
            InitializeComponent();
            StkAmount.IsVisible = true;
            StkAddAmount.IsVisible = false;
            StkAddAmountDetails.IsVisible = false;
        }

        private void Close_Clicked(object sender, EventArgs e)
        {
            Dismiss(null);            
        }

        private void TopUp_Clicked(object sender, EventArgs e)
        {
            StkAmount.IsVisible = false;           
            StkAddAmount.IsVisible = true;
            StkAddAmountDetails.IsVisible = false;
        }

        private void AddMoney_Tapped(object sender, EventArgs e)
        {
            StkAmount.IsVisible = false;
            StkAddAmount.IsVisible = false;
            StkAddAmountDetails.IsVisible = true;
        }

        private async void AddMoneyDetails_Tapped(object sender, EventArgs e)
        {
            Dismiss(null);
            await RichNavigation.PushAsync(new GCashPage(), typeof(GCashPage));
        }
    }
}