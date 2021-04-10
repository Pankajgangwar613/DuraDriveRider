using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DuraDriveRider.NavigationService
{
    public class RichNavigation
    {
        public static async Task PushAsync(Page page, Type type, bool isAnimated = true)
        {
            var i = App.Current.MainPage.Navigation.NavigationStack.LastOrDefault();
            if (i == null)
            {
                await App.Current.MainPage.Navigation.PushAsync(page, isAnimated);
                return;
            }
            if (i.GetType() != type)
            {
                await App.Current.MainPage.Navigation.PushAsync(page, isAnimated);
                return;
            }
        }
        public static async Task PushModelAysnc(Page page, Type type, bool isAnimated = true)
        {
            var i = App.Current.MainPage.Navigation.NavigationStack.LastOrDefault();
            if (i == null)
            {
                await App.Current.MainPage.Navigation.PushModalAsync(page, isAnimated);
                return;
            }
            if (i.GetType() != type)
            {
                await App.Current.MainPage.Navigation.PushModalAsync(page, isAnimated);
                return;
            }
        }
        public static async Task PopAsync()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }
        public static async Task PopModelAsync()
        {
            try
            {
                await App.Current.MainPage.Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
