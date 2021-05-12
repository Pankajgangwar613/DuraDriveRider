﻿using DuraDriveRider.Infrastructure;
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
    public partial class DocumentPage : BaseContentPage
    {
        public DocumentPage()
        {
            InitializeComponent();
            BindingContext = new DocumentPageViewModel();
        }
    }
}