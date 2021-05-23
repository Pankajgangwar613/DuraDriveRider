using DuraDriveRider.NavigationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuraDriveRider.Pages.XctTabView.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MapRoutePage : ContentPage
	{
		public MapRoutePage ()
		{
			InitializeComponent ();
			//BackPage();
		}

		private async void BackPage()
		{
			await RichNavigation.PopAsync();
			//await Task.Delay(500);
		}

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
			await RichNavigation.PopAsync();
		}
    }
}