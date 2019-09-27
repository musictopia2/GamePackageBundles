using BasicGameFramework.StandardImplementations.CrossPlatform.GlobalClasses;
using BasicGameFramework.StandardImplementations.XamarinForms.Interfaces;
using BasicXFControlsAndPages.Helpers;
using CommonBasicStandardLibraries.MVVMHelpers.Interfaces;
using System;
using System.Threading.Tasks; //most of the time, i will be using asyncs.
using Xamarin.Forms;
namespace GamePackageSettingsApp
{
    public class StartPage : ContentPage, IHostedUIInterface, ISimpleUI
    {
        private readonly IGamePlatform _platform;
        public StartPage(IGamePlatform platform)
        {
            _platform = platform;
            Init();
        }
        private async void Init()
        {
            GlobalDataViewModel thisMod = new GlobalDataViewModel(new GlobalDataLoaderClass(this), this);
            await thisMod.InitAsync();
            DataEntryHelper helps = new DataEntryHelper(thisMod);
            BindingContext = thisMod;
            if (thisMod.MainNickName == "")
                helps.AddNormalTextRow("Main Nick Name", nameof(GlobalDataViewModel.MainNickName));
            else
                helps.AddNormalTextRow("Secondary Nick Name", nameof(GlobalDataViewModel.SecondaryNickName));
            helps.AddNormalTextRow("Azure End Point", nameof(GlobalDataViewModel.AzureEndPointAddress));
            helps.AddNormalTextRow("Local Address", nameof(GlobalDataViewModel.HostIPAddress));
            helps.AddButton("Home Hosting", nameof(GlobalDataViewModel.ChangeServerOptionsCommand), EnumServerMode.HomeHosting);
            helps.AddButton("Azure Hosting", nameof(GlobalDataViewModel.ChangeServerOptionsCommand), EnumServerMode.AzureHosting);
            helps.AddButton("Local Hosting", nameof(GlobalDataViewModel.ChangeServerOptionsCommand), EnumServerMode.LocalHosting);
            helps.AddButton("Host In App", nameof(GlobalDataViewModel.ChangeServerOptionsCommand), EnumServerMode.MobileServer);
            helps.AddButton("Default Azure EP", nameof(GlobalDataViewModel.DefaultAzureCommand));
            helps.AddButton("Clear Azure", nameof(GlobalDataViewModel.ClearAzureCommand));
            helps.AddLabelRow("Current Nick Name", nameof(GlobalDataViewModel.CurrentNickName));
            helps.AddLabelRow("Server Hosting Option", nameof(GlobalDataViewModel.ServerMode), new ServerConverter());
            helps.AddButton("Save Settings", nameof(GlobalDataViewModel.SaveCommand));
            helps.AddButton("Use Main Nick Name", nameof(GlobalDataViewModel.MainNickCommand));
            ScrollView scroll = new ScrollView();
            scroll.Orientation = ScrollOrientation.Both; //try both this time.
            scroll.Content = helps.CurrentGrid;
            Content = scroll;
        }
        bool IHostedUIInterface.IsXamarinForms => true;

        void IClose.CloseProgram()
        {
            _platform.CloseApp();
        }

        async void IError.ShowError(string message)
        {
            await PrivateShowErrorAsync(message);
        }
        private async Task PrivateShowErrorAsync(string message)
        {
            await DisplayAlert("Error", message, "okay");
            _platform.CloseApp();
        }
        async Task IMessage.ShowMessageBox(string message)
        {
            await DisplayAlert(Title, message, "Okay");
            _platform.ResetPopups();
        }
    }
}