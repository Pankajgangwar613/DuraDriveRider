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
  public  class ReviewPageViewModel : BaseViewModel
    {
        public ICommand SubmitCommand => new Command(async (obj) =>
        {
            await RichNavigation.PushAsync(new HomeXctTab(0), typeof(HomeXctTab));
        });
        public ICommand ReviewCommand => new Command(async (obj) =>
        {
            await RichNavigation.PushAsync(new HomeXctTab(0), typeof(HomeXctTab));
        });
    }
}
