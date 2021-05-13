using DuraDriveRider.Pages.Auth.PopUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuraDriveRider.Pages.XctTabView.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeclinePopUp 
    {
        public DeclinePopUp()
        {
            InitializeComponent();
        }

        private void NoDiscard_Clicked(object sender, EventArgs e)
        {
            Dismiss(null);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string  JobTitle="Job Decline";
            Navigation.ShowPopup(new SuccessfullyPopup(JobTitle));
            Dismiss(null);
        }
    }
}