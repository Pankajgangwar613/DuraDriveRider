﻿using DuraDriveRider.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.Profile.ViewModels
{
   public class QrCodePageViewModel : BaseViewModel
    {
        public ICommand ShareCommand => new Command(async (obj) =>
        {
            //await RichNavigation.PushAsync(new MyPointsPage(), typeof(MyPointsPage));
        });
    }
}
