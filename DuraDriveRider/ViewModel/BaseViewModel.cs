using Acr.UserDialogs;
using DuraDriveRider.NavigationService;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace DuraDriveRider.ViewModel
{
    public class BaseViewModel : ObservableObject
    {
        
        public ICommand BackCommand { get; }
        public ICommand ClosePopUpCommand { get; }
        public BaseViewModel()
        {
            Initialize();
            BackCommand = CommandFactory.Create(Back);
            ClosePopUpCommand = CommandFactory.Create(async () =>
            {
                //Navigation.ShowPopup(new SuccessfullyPopup());
                //await Task.Delay(500);
                //Dismiss(null);
                await PopupNavigation.PopAsync();
            });
        }
        async Task Back()
        {
            await RichNavigation.PopAsync();
        }

        public ICommand HomeShellCommand = CommandFactory.Create(async(obj)=>
        {
            //  App.Current.MainPage = new HomeMenuShell();
        }); 

        public ICommand FlyoutIsPresentedCommand => new Command(async (obj) =>
        {
            try
            {
                //if (HomeMenuShell.Current.FlyoutIsPresented)
                //    HomeMenuShell.Current.FlyoutIsPresented = false;
                //else
                //    HomeMenuShell.Current.FlyoutIsPresented = true;
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.Alert(ex.Message);
            }
        });
        public ICommand LogoutCommand => new Command(async (obj) =>
        {
            // App.Current.MainPage = new MaterialNavigationPage(new LoginPage());
        });

        protected NavigationPage _navigation => (Application.Current.MainPage as NavigationPage) ?? Application.Current.MainPage as NavigationPage;
       
        private object _parameter;

        public bool IsInitializedBase { get; protected set; }

        public bool IsInitialized { get; protected set; } = false;  

        private void Initialize()
        {
            if (IsInitializedBase)
                return;
            IsInitializedBase = true;
        }
        public virtual async Task OnPageAppearing() { }

        public virtual async Task OnPageDisappearing() { }
        protected IUserDialogs _userDialogs => UserDialogs.Instance;
        protected void ShowLoading() => _userDialogs.ShowLoading();  
        protected void HideLoading()=> _userDialogs.HideLoading(); 
        protected void ShowAlert(string message, string title = "", string acknowledgeText = "OK")
        {
            _userDialogs.Alert(message, title, acknowledgeText);
        }
        protected void ShowToast(string message)
        {
            _userDialogs.Toast(message);
        }
        protected async Task<bool> ShowConfirmationAlert(string message, string title = "", string acknowledgeOkText = "OK", string acknowledgeCancelText = "Cancel")
        {
            return await _userDialogs.ConfirmAsync(message, title, acknowledgeOkText, acknowledgeCancelText);
        }
        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
        public virtual void ClearData()
        {
            IsInitializedBase = false;
        }
    }
}