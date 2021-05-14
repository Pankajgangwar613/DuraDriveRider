using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.XctTabView.Views;
using DuraDriveRider.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.XctTabView.ViewModels
{
   public class VerifyItemPageViewModel : BaseViewModel
    {
        public ICommand ValidateCommand => new Command(async (obj) =>
        {
            await RichNavigation.PopAsync();
        });
    }
}