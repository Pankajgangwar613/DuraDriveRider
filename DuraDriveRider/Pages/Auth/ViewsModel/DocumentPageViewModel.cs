using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.Auth.Views;
using DuraDriveRider.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.Auth.ViewsModel
{
   public class DocumentPageViewModel : BaseViewModel
    {
        public ObservableCollection<string> LoginList { get; set; } = new ObservableCollection<string>
        {
            "Motorbike","MPV","VAN","FB","Aluminum"
        };
        public ICommand NextCommand => new Command(async (obj) =>
        {
            await RichNavigation.PushAsync(new BankInfoPage(), typeof(BankInfoPage));
        });
    }
}