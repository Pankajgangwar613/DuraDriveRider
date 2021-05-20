using DuraDriveRider.Pages.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuraDriveRider.Pages.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SuccessfulPage : ContentPage
    {
        public SuccessfulPage()
        {
            InitializeComponent();
            BindingContext = new SuccessfulPageViewModel();
        }
    }
}