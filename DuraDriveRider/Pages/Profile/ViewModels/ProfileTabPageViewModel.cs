using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.Auth.Views;
using DuraDriveRider.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.Profile.ViewModels
{
   public class ProfileTabPageViewModel : BaseViewModel
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
        public ProfileTabPageViewModel()
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
        }

        public ICommand PasswordChangeCommand => new Command(async (obj) =>
        {
           await RichNavigation.PushAsync(new ChangePasswordPage(), typeof(ChangePasswordPage));
        });
        public ICommand Tab1Command => new Command(async (obj) =>
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
        public ICommand Tab2Command => new Command(async (obj) =>
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
        public ICommand Tab3Command => new Command(async (obj) =>
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
    }
}
