using DuraDriveRider.Infrastructure;
using DuraDriveRider.Pages.Auth.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuraDriveRider.Pages.Auth.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BankInfoPage : BaseContentPage
    {
        public BankInfoPage()
        {
            InitializeComponent();
            BindingContext = new BankInfoPageViewModel();
        }
    }
}