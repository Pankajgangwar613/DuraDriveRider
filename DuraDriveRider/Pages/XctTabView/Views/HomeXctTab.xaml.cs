using DuraDriveRider.Infrastructure;
using DuraDriveRider.Pages.XctTabView.PopUp;
using DuraDriveRider.Pages.XctTabView.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit.UI.Views.Options;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuraDriveRider.Pages.XctTabView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeXctTab : BaseContentPage
    { 
        public HomeXctTab(int SelectedTab)
        {
            InitializeComponent();
            BindingContext = new HomeXctTabViewModel();            
            if (SelectedTab == 1)
            {
                MyTabView.SelectedIndex = 1;
            }
            else if (SelectedTab == 2)
            {
                MyTabView.SelectedIndex = 2;
            }
            else if (SelectedTab == 3)
            {
                MyTabView.SelectedIndex = 3;
            }  
            else
            {
                MyTabView.SelectedIndex = 0;
                Navigation.ShowPopup(new DuraExpressPopUp()); 
            }                        
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            this.DisplayToastAsync("Toast"); 
        }

        private void TopUp_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new AmountPopup());
        }
    }
}