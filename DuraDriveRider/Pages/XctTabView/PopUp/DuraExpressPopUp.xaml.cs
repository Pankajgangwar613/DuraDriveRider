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
    public partial class DuraExpressPopUp 
    {
        public DuraExpressPopUp()
        {
            InitializeComponent();
        }

        private void Decline_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new DeclinePopUp());
        }

        private void Accept_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new DeclinePopUp());
        }
    }
}