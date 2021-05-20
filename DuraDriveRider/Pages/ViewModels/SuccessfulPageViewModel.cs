using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.XctTabView.Views;
using DuraDriveRider.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.ViewModels
{
   public class SuccessfulPageViewModel : BaseViewModel
    {
        public ICommand OkayCommand => new Command(async (obj) =>
        {
            await RichNavigation.PushAsync(new HomeXctTab(2), typeof(HomeXctTab));
        });
    }
}
