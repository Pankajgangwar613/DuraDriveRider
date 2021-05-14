using DuraDriveRider.Infrastructure;
using DuraDriveRider.Pages.Profile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuraDriveRider.Pages.Profile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SupportPage : BaseContentPage
    {
        public SupportPage()
        {
            InitializeComponent();
            BindingContext = new SupportPageViewModel();
        }
    }
}