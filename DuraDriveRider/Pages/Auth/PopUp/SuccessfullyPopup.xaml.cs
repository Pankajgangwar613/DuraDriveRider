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
        private string jobTitle;
        public SuccessfullyPopup()
        {
            InitializeComponent();
            LoadDissmisspop();
            lblTitle.Text = "Password Reset Successfully !";
        }

        public SuccessfullyPopup(string jobTitle)
        {
            InitializeComponent();
           // this.jobTitle = jobTitle;
            lblTitle.Text = jobTitle;
            LoadDissmisspop();
        }

        private async void LoadDissmisspop()
        {
            await Task.Delay(800);
            Dismiss(null);
        }
    }
}