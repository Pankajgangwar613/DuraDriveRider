using DuraDriveRider.Pages.Auth.PopUp;
using DuraDriveRider.Pages.XctTabView.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace DuraDriveRider
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {            
           // Dismiss(null);
           // App.Current.MainPage = new HomeXctTab();
        }
    }
}
