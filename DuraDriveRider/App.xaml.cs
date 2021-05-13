using DuraDriveRider.Pages.Auth.Views;
using DuraDriveRider.Pages.Views;
using DuraDriveRider.Pages.XctTabView.Views;
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
            XF.Material.Forms.Material.Init(this);
           MainPage = new MaterialNavigationPage(new LoginPage());
          // App.Current.MainPage = new HomeXct();
            LocalizationResourceManager.Current.Init(AppResources.ResourceManager);
            //AppResources.Culture = CrossMultilingual.Current.DeviceCultureInfo; 
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
