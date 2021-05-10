using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using XF.Material.Forms.UI;

namespace DuraDriveRider.Infrastructure
{
    public class BaseContentPage : ContentPage
    {
        public BaseContentPage()
        {
            this.On<iOS>().SetUseSafeArea(true);
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
            MaterialNavigationPage.SetStatusBarColor(this, (Color.FromHex("#211E66")));
            BackgroundColor = Color.FromHex("#211E66");
            //MaterialNavigationPage.SetAppBarColor(this, (Color)App.AppInstance.Resources["StartGradientColor"]);
        }
        protected async override void OnAppearing()
        {
            // await (this.BindingContext as BaseViewModel).OnPageAppearing();
            base.OnAppearing();
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}