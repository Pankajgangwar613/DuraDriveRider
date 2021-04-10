using DuraDriveRider.Resources;
using System;
using Xamarin.CommunityToolkit.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Material.Forms.UI;

namespace DuraDriveRider
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MaterialNavigationPage(new MainPage()); 
            XF.Material.Forms.Material.Init(this);
            LocalizationResourceManager.Current.Init(AppResources.ResourceManager);
            //AppResources.Culture = CrossMultilingual.Current.DeviceCultureInfo; 
            // MainPage = new MaterialNavigationPage(new AdentureBannerPage()); 
            //SetFlags(new string[] { "Shell_UWP_Experimental", "AnotherFeature_Experimental" });
            }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
