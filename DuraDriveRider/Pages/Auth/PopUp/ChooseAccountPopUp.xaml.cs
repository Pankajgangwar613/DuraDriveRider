﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DuraDriveRider.Pages.Auth.PopUp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseAccountPopUp 
    {
        public ChooseAccountPopUp()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Dismiss(null);
        }
    }
}