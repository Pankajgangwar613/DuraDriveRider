using Acr.UserDialogs;
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
using XF.Material.Forms.Models;
using XF.Material.Forms.UI;
using XF.Material.Forms.UI.Dialogs;

namespace DuraDriveRider.Pages.XctTabView.ViewModels
{
   public class HomeXctTabViewModel : BaseViewModel
    {

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
        public ObservableCollection<string> PaymentList { get; set; } = new ObservableCollection<string>
        {
            "All","E-Wallet txn","Cash Wallet"
        };
        private void MaterialMenuButton_MenuSelected(object sender, MenuSelectedEventArgs e)
        {
            MaterialDialog.Instance.AlertAsync("MenuSelected");
        }
        public MaterialMenuItem[] Actions => new MaterialMenuItem[]
       {
            new MaterialMenuItem
            {
                Text = "Edit"
            },
            new MaterialMenuItem
            {
                Text = "Delete"
            }
       };

        public ICommand MenuCommand = new Command(
            execute: (arg) =>
            {
                MaterialDialog.Instance.AlertAsync("MenuCommand");
            },
            canExecute: (x) =>
            {
                bool? retval = MaterialDialog.Instance.ConfirmAsync(message: "Allow Menu?", confirmingText: "Yes", dismissiveText: "No").Result;
                return (retval.HasValue && retval.Value == true);
            });

        public ObservableCollection<ProfileModel> EWalletOfList { get; set; } = new ObservableCollection<ProfileModel>()
        {
            new ProfileModel{ TitleName = "#14565636664" }, 
            new ProfileModel{ TitleName = "#14565636664" }, 
            new ProfileModel{ TitleName = "#14565636664" }, 
            new ProfileModel{ TitleName = "#14565636664" }, 
            new ProfileModel{ TitleName = "#14565636664" }, 
            new ProfileModel{ TitleName = "#14565636664" }, 
            new ProfileModel{ TitleName = "#14565636664" }, 
            new ProfileModel{ TitleName = "#14565636664" }, 
            new ProfileModel{ TitleName = "#14565636664" }, 
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
