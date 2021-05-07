using DuraDriveRider.Infrastructure;
using DuraDriveRider.Pages.XctTabView.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit.UI.Views.Options;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuraDriveRider.Pages.XctTabView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeXctTab : BaseContentPage
    {
        public HomeXctTab()
        {
            InitializeComponent();
            BindingContext = new HomeXctTabViewModel();
        }
		 
		private void Button_Clicked(object sender, EventArgs e)
        {
            this.DisplayToastAsync("Toast"); 
        }
    }
}