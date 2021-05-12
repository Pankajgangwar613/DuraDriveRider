using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.Auth.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuraDriveRider.Pages.Auth.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReferralCodePopup 
    {
        public ReferralCodePopup()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Dismiss(null);
            await RichNavigation.PushAsync(new DocumentPage(), typeof(DocumentPage));
        }

        private async void Submit_Clicked(object sender, EventArgs e)
        {
            Dismiss(null);
            await RichNavigation.PushAsync(new DocumentPage(), typeof(DocumentPage));
        } 
    }
}