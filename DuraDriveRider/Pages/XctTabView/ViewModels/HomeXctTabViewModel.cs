using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.XctTabView.Model;
using DuraDriveRider.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using XF.Material.Forms.UI;

namespace DuraDriveRider.Pages.XctTabView.ViewModels
{
   public class HomeXctTabViewModel : BaseViewModel
    {

        bool enableCache;
        string email = "dsiegel@avantipoint.com";
        int size = 50;
        DefaultGravatar defaultGravatar = DefaultGravatar.MysteryPerson;

        public DefaultGravatar[] Defaults { get; } = new[]
        {
            DefaultGravatar.Blank,
            DefaultGravatar.FileNotFound,
            DefaultGravatar.Identicon,
            DefaultGravatar.MonsterId,
            DefaultGravatar.MysteryPerson,
            DefaultGravatar.Retro,
            DefaultGravatar.Robohash,
            DefaultGravatar.Wavatar
        };

        public bool EnableCache
        {
            get => enableCache;
            set => SetProperty(ref enableCache, value);
        }

        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        public int Size
        {
            get => size;
            set => SetProperty(ref size, value);
        }

        public DefaultGravatar DefaultGravatar
        {
            get => defaultGravatar;
            set => SetProperty(ref defaultGravatar, value);
        }
    

    public ICommand FullscreenLoadingCommand { get; }

        public ICommand CycleStatesCommand { get; }

        //public HomeXctTabViewModel()
        //{
        //    FullscreenLoadingCommand = CommandFactory.Create(async () =>
        //    {
        //        MainState = LayoutState.Loading;
        //        await Task.Delay(2000);
        //        MainState = LayoutState.None;
        //    });
        //    CycleStatesCommand = CommandFactory.Create(CycleStates);
        //}

        //async Task CycleStates()
        //{
        //    CurrentState = LayoutState.Loading;
        //    await Task.Delay(3000);
        //    CurrentState = LayoutState.Saving;
        //    await Task.Delay(3000);
        //    CurrentState = LayoutState.Error;
        //    await Task.Delay(3000);
        //    CurrentState = LayoutState.Empty;
        //    await Task.Delay(3000);
        //    CurrentState = LayoutState.Custom;
        //    CustomState = "ThisIsCustomHi";
        //    await Task.Delay(3000);
        //    CustomState = "ThisIsCustomToo";
        //    await Task.Delay(3000);
        //    CurrentState = LayoutState.Success;
        //    await Task.Delay(3000);
        //    CurrentState = LayoutState.None;
        //}


        //Wallet
        public ObservableCollection<string> ProfileNameList { get; set; }=new ObservableCollection<string>
        {
            "hi, John"
        };


        //Profile
        public ObservableCollection<ProfileModel> ProfileItems { get; set; } = new ObservableCollection<ProfileModel>()
        {
            new ProfileModel {id=1,Images="qr_code", TitleName = "My QR Code" },
            new ProfileModel {id=2,Images="Share", TitleName = "Refer a Rider"},
            new ProfileModel {id=3,Images="my_ratings", TitleName = "My Ratings"},
            new ProfileModel {id=4,Images="support", TitleName = "Support"},
            new ProfileModel {id=5,Images="help_center", TitleName = "Help Center" },
            new ProfileModel {id=6,Images="privacy_policy", TitleName = "Privacy Policy" },
            new ProfileModel {id=7,Images="TermsCondition", TitleName = "Terms & Condition" },
        };

        public ICommand ViewProfileCommand => new Command(async (obj) =>
        {
            //await RichNavigation.PushAsync(new MyPointsPage(), typeof(MyPointsPage));
        });
        
        public ICommand LogOutCommand => new Command(async (obj) =>
        {
            //App.Current.MainPage = new MaterialNavigationPage(new LogInPage());
            //Settings.IsWalkthroughCompleted = false;
        });

        public ICommand ProfileTapCommand => new Command(async (obj) =>
        {
            var ProfileMdl = obj as ProfileModel;
            switch (ProfileMdl.id)
            {
                case 1:
                   // await RichNavigation.PushAsync(new MyPointsPage(), typeof(MyPointsPage));
                    break;
                case 2:
                    //await RichNavigation.PushAsync(new HealthConditionPage(), typeof(HealthConditionPage));
                    break;
                case 3:
                    //await RichNavigation.PushAsync(new NotificationPage(), typeof(NotificationPage));
                    break;
                case 4:
                    //await RichNavigation.PushAsync(new AboutUsPage(), typeof(AboutUsPage));
                    break;
                case 5:
                    //await RichNavigation.PushAsync(new SettingsPage(), typeof(SettingsPage));
                    break;
                case 6:
                  //  await RichNavigation.PushAsync(new ContactUsPage(), typeof(ContactUsPage));
                    break; 
                case 9:
                    // App.Current.MainPage = new MaterialNavigationPage(new LogInPage());
                    //Settings.IsWalkthroughCompleted = false;
                    break;
            }
        });    
    }
}
