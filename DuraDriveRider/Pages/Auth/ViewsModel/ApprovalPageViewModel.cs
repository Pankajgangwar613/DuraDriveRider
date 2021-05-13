using DuraDriveRider.Pages.XctTabView.Views;
using DuraDriveRider.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.Auth.ViewsModel
{
   public class ApprovalPageViewModel :BaseViewModel
    {
        public ICommand ApprovalCommand => new Command(async (obj) =>
        {              
             App.Current.MainPage = new HomeXctTab(3);
        });
    }
}
