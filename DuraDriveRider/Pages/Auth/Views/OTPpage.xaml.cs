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
    public partial class OTPpage : ContentPage
    {
        public OTPpage()
        {
            InitializeComponent();
            BindingContext = new OTPpageViewModel();
        }
        void VerifyEntryText_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if (sender != null)
            {
                var value = e.NewTextValue;
                var selectedEntry = (Entry)sender;
                switch (selectedEntry.AutomationId)
                {
                    case "1":
                        if (!string.IsNullOrEmpty(value))
                        {
                            Pin1.Unfocus();
                            Pin2.Focus();
                            Pin3.Unfocus();
                            Pin4.Unfocus();
                        }
                        break;
                    case "2":
                        if (!string.IsNullOrEmpty(value))
                        {
                            Pin1.Unfocus();
                            Pin2.Unfocus();
                            Pin3.Focus();
                            Pin4.Unfocus();
                        }
                        break;
                    case "3":
                        if (!string.IsNullOrEmpty(value))
                        {
                            Pin1.Unfocus();
                            Pin2.Unfocus();
                            Pin3.Unfocus();
                            Pin4.Focus();
                        }
                        break;
                    case "4":
                        if (!string.IsNullOrEmpty(value))
                        {
                            Pin1.Unfocus();
                            Pin2.Unfocus();
                            Pin3.Unfocus();
                            Pin4.Unfocus();
                            //  NewPin1.Focus();
                        }
                        break;
                }

            }
        }
    }
}