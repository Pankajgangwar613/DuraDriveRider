﻿using DuraDriveRider.NavigationService;
using DuraDriveRider.Pages.Auth.Views;
using DuraDriveRider.Pages.XctTabView.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.Auth.ViewsModel
{
   public class LoginPageViewModel
    {
        public ObservableCollection<string> LoginList { get; set; } = new ObservableCollection<string>
        {
            "Raj","Manila"
        };
        public ObservableCollection<string> CountryCodeList { get; set; } = new ObservableCollection<string>
        {
            "+ 63","+ 91"
        };
        public ICommand ForgotCommand => new Command(async (obj) =>
        {
            await RichNavigation.PushAsync(new ForgotPasswordPage(), typeof(ForgotPasswordPage));
        });
        public ICommand LoginCommand => new Command(async (obj) =>
        {
            App.Current.MainPage = new HomeXctTab();
        });

        public ICommand RegisterCommand => new Command(async (obj) =>
        {
            //await RichNavigation.PushAsync(new ForgotPasswordPage(), typeof(ForgotPasswordPage));
        });       
    }
}