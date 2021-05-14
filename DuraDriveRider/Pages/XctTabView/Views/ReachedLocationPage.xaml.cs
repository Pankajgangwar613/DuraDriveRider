using DuraDriveRider.Infrastructure;
using DuraDriveRider.Pages.XctTabView.ViewModels;
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
    public partial class ReachedLocationPage : BaseContentPage
    {
        public ReachedLocationPage()
        {
            InitializeComponent();
            BindingContext = new ReachedLocationPageViewModel();
        }
    }
}