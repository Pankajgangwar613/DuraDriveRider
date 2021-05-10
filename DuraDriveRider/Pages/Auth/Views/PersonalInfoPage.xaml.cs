using DuraDriveRider.Infrastructure;
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
    public partial class PersonalInfoPage : BaseContentPage
    {
        public PersonalInfoPage()
        {
            InitializeComponent();
            BindingContext = new PersonalInfoPageViewModel();
        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new ReferralCodePopup()); 
        }
    }
}