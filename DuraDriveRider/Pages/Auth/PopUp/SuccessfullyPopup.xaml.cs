using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuraDriveRider.Pages.Auth.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SuccessfullyPopup 
    {
        private string title; 
        public SuccessfullyPopup(string title)
        {
            InitializeComponent(); 
            lblTitle.Text = title;
            LoadDissmisspop();
        }

        private async void LoadDissmisspop()
        {
            await Task.Delay(800);
            Dismiss(null);
        }
    }
}