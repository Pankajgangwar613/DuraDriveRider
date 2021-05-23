using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.Auth.Views;
using DuraDriveRider.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.Auth.ViewsModel
{
   public class DuraBageServicePageViewModel : BaseViewModel
    {
        private string _checkedImage;
        public string CheckedImage
        {
            get { return _checkedImage; }
            set { _checkedImage = value;OnPropertyChanged(); }
        }
        private string _unCheckedImage;
        public string UnCheckedImage
        {
            get { return _unCheckedImage; }
            set { _unCheckedImage = value;OnPropertyChanged(); }
        }
        public DuraBageServicePageViewModel()
        {
            CheckedImage = "check";
            UnCheckedImage = "uncheck";
        }

        public ICommand NextCommand => new Command(async (obj) =>
        {
            await RichNavigation.PushAsync(new ApprovalPage(), typeof(ApprovalPage));
        });
        public ICommand SelectDuraBagCommand => new Command(async (obj) =>
        {
            CheckedImage = "check";
            UnCheckedImage = "uncheck";
        });
        public ICommand UnSelectDuraBagCommand => new Command(async (obj) =>
        {
            CheckedImage = "uncheck";
            UnCheckedImage = "check";
        });
    }
}
