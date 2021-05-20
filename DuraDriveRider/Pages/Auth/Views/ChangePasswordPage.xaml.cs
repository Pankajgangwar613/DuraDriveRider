using DuraDriveRider.Infrastructure;
using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.Auth.PopUp;
using DuraDriveRider.Pages.Auth.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuraDriveRider.Pages.Auth.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangePasswordPage : BaseContentPage
    {
        public ChangePasswordPage()
        {
            InitializeComponent();
           BindingContext=new ChangePasswordPageViewModel();
        }

        private async void Submit_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new SuccessfullyPopup("Password change Successfully"));
            await RichNavigation.PopAsync();
        }
    }
}