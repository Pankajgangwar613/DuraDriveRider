using DuraDriveRider.NavigationService;
using DuraDriveRider.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DuraDriveRider.Pages.ViewModels
{
   public class NotificationPageViewModel : BaseViewModel
    {
        public class NotificationModel
        {
            public string Images { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Date { get; set; }
        }
        public ObservableCollection<NotificationModel> NotificationData { get; set; } = new ObservableCollection<NotificationModel>()
        {
            new NotificationModel() { Title="Notifications Title", Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor. Lorem ipsum dolor sit amet, consetetur sadipscing elitr,",Date="05 Feb 2021"},
            new NotificationModel() { Title="Notifications Title", Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor. Lorem ipsum dolor sit amet, consetetur sadipscing elitr,",Date="05 Feb 2021"},
            new NotificationModel() { Title="Notifications Title", Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor. Lorem ipsum dolor sit amet, consetetur sadipscing elitr,",Date="05 Feb 2021"},
            new NotificationModel() { Title="Notifications Title", Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor. Lorem ipsum dolor sit amet, consetetur sadipscing elitr,",Date="05 Feb 2021"},
            new NotificationModel() { Title="Notifications Title", Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor. Lorem ipsum dolor sit amet, consetetur sadipscing elitr,",Date="05 Feb 2021"},
            new NotificationModel() { Title="Notifications Title", Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor. Lorem ipsum dolor sit amet, consetetur sadipscing elitr,",Date="05 Feb 2021"},
            new NotificationModel() { Title="Notifications Title", Description = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor. Lorem ipsum dolor sit amet, consetetur sadipscing elitr,",Date="05 Feb 2021"},
        };
        public ICommand NotificationCommand => new Command(async (obj) =>
        {
          //await RichNavigation.PushAsync(new PaymentSuccessPage(), typeof(PaymentSuccessPage));
        });
    }
}
