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
        private Color _personalDetailsTextColor = Color.Black;
        public Color PersonalDetailsTextColor
        {
            get => _personalDetailsTextColor;
            set { _personalDetailsTextColor = value; OnPropertyChanged(); }
        }

        private Color _personalDetailsBoxviewColor = Color.FromHex("#267EAA");
        public Color PersonalDetailsBoxviewColor
        {
            get => _personalDetailsBoxviewColor;
            set { _personalDetailsBoxviewColor = value; OnPropertyChanged(); }
        }
        private Color _officalDetailsTextColor = Color.Gray;
        public Color OfficalDetailsTextColor
        {
            get => _officalDetailsTextColor;
            set { _officalDetailsTextColor = value; OnPropertyChanged(); }
        }

        private Color _officalDetailsBoxviewColor = Color.WhiteSmoke;
        public Color OfficalDetailsBoxviewColor
        {
            get => _officalDetailsBoxviewColor;
            set { _officalDetailsBoxviewColor = value; OnPropertyChanged(); }
        }

        private Color _paymentDetailsTextColor = Color.Gray;
        public Color PaymentDetailsTextColor
        {
            get => _paymentDetailsTextColor;
            set { _paymentDetailsTextColor = value; OnPropertyChanged(); }
        }

        private Color _paymentDetailsBoxviewColor = Color.WhiteSmoke;
        public Color PaymentDetailsBoxviewColor
        {
            get => _paymentDetailsBoxviewColor;
            set { _paymentDetailsBoxviewColor = value; OnPropertyChanged(); }
        }


        private bool _personalDetailsIsVisible;
        public bool PersonalDetailsIsVisible
        {
            get { return _personalDetailsIsVisible; }
            set { _personalDetailsIsVisible = value; OnPropertyChanged(); }
        }

        private bool _officialDetailsIsVisible;
        public bool OfficialDetailsIsVisible
        {
            get { return _officialDetailsIsVisible; }
            set { _officialDetailsIsVisible = value; OnPropertyChanged(); }
        }


        private bool _paymentDetailsIsVisible;
        public bool PaymentDetailsIsVisible
        {
            get { return _paymentDetailsIsVisible; }
            set { _paymentDetailsIsVisible = value; OnPropertyChanged(); }
        }

        private ImageSource _profileImage;
        public ImageSource ProfileImage
        {
            get { return _profileImage; }
            set { _profileImage = value; OnPropertyChanged(nameof(ProfileImage)); }
        }
        private string _accountName;
        public string AccountName
        {
            get { return _accountName; }
            set { _accountName = value; OnPropertyChanged(); }
        }
        private string _paypalId;
        public string PaypalId
        {
            get { return _paypalId; }
            set { _paypalId = value; OnPropertyChanged(); }
        }
        private string _bankName;
        public string BankName
        {
            get { return _bankName; }
            set { _bankName = value; OnPropertyChanged(); }
        }
        private string _accountNumber;
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; OnPropertyChanged(); }
        }
        public ICommand FullscreenLoadingCommand { get; }

        public ICommand CycleStatesCommand { get; }

        public HomeXctTabViewModel()
        {
            PersonalDetailsIsVisible = true;
            OfficialDetailsIsVisible = false;
            PaymentDetailsIsVisible = false;
            PersonalDetailsTextColor = Color.White;
            PersonalDetailsBoxviewColor = Color.FromHex("#211E66");
            OfficalDetailsBoxviewColor = Color.Transparent;
            OfficalDetailsTextColor = Color.FromHex("#75747F");
            PaymentDetailsBoxviewColor = Color.Transparent;
            PaymentDetailsTextColor = Color.FromHex("#75747F");
            //FullscreenLoadingCommand = CommandFactory.Create(async () =>
            //{
            //    MainState = LayoutState.Loading;
            //    await Task.Delay(2000);
            //    MainState = LayoutState.None;
            //});
            //CycleStatesCommand = CommandFactory.Create(CycleStates);
        }

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

        //Order
        public ObservableCollection<string> DaysList { get; set; } = new ObservableCollection<string>
        {
            "Today"
        };

        public ICommand PersonalDetailsCommand => new Command(async (obj) =>
        {
            PersonalDetailsIsVisible = true;
            OfficialDetailsIsVisible = false;
            PaymentDetailsIsVisible = false;
            PersonalDetailsTextColor = Color.White;
            PersonalDetailsBoxviewColor = Color.FromHex("#211E66");
            OfficalDetailsBoxviewColor = Color.Transparent;
            OfficalDetailsTextColor = Color.FromHex("#75747F");
            PaymentDetailsBoxviewColor = Color.Transparent;
            PaymentDetailsTextColor = Color.FromHex("#75747F");
        });
        public ICommand OfficalDetailsCommand => new Command(async (obj) =>
        {
            PersonalDetailsIsVisible = false;
            OfficialDetailsIsVisible = true;
            PaymentDetailsIsVisible = false;
            PersonalDetailsTextColor = Color.FromHex("#75747F");
            PersonalDetailsBoxviewColor = Color.Transparent;
            OfficalDetailsBoxviewColor = Color.FromHex("#211E66");
            OfficalDetailsTextColor = Color.White;
            PaymentDetailsTextColor = Color.FromHex("#75747F"); ;
            PaymentDetailsBoxviewColor = Color.Transparent;
        });

        public ICommand PaymentDetailsCommand => new Command(async (obj) =>
        {
            PersonalDetailsIsVisible = false;
            OfficialDetailsIsVisible = false;
            PaymentDetailsIsVisible = true;
            PersonalDetailsBoxviewColor = Color.Transparent;
            PersonalDetailsTextColor = Color.FromHex("#75747F");
            OfficalDetailsBoxviewColor = Color.Transparent;
            OfficalDetailsTextColor = Color.FromHex("#75747F");
            PaymentDetailsTextColor = Color.White;
            PaymentDetailsBoxviewColor = Color.FromHex("#211E66");
        });

        public ObservableCollection<OrderModel> DuraExpressOfList { get; set; } = new ObservableCollection<OrderModel>()
        {
          //  new OrderModel{ TitleName = "#14565636664" },
        };

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
