﻿using DuraDriveRider.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.Auth.ViewsModel
{
   public class PersonalInfoPageViewModel : BaseViewModel
    {

        public ICommand RegisterCommand => new Command(async (obj) =>
        { 
            //await RichNavigation.PushAsync(new OTPpage(), typeof(OTPpage));
        });
    }
}
