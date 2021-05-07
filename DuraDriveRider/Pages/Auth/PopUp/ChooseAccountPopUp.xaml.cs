using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuraDriveRider.Pages.Auth.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseAccountPopUp : Popup
    {
        public ChooseAccountPopUp()
        {
            InitializeComponent();
        } 
    }
}