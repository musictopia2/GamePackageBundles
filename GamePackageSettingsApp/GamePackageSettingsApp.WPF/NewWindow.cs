using BasicControlsAndWindowsCore.BasicWindows.Windows;
using BasicControlsAndWindowsCore.Helpers;
using BasicGameFramework.StandardImplementations.CrossPlatform.GlobalClasses;
using System.Windows;
namespace GamePackageSettingsApp.WPF
{
    internal class NewWindow : PlainWindow<GlobalDataViewModel>, IHostedUIInterface //default is basic view model but can change to what you want.
    {
        bool IHostedUIInterface.IsXamarinForms => false;

        protected override async void AfterInitialBuild()
        {
            DataEntryHelpers helps = new DataEntryHelpers(ThisMod);
            ThisMod.Title = "Game Package Global Settings";
            //looks like for now, generic buttons don't work unless you actually send the icommand for now.
            //if i attempted to fix, then it ruins the nuget package for now.
            //probably for now not as important.
            //can fix for .net 5 though.
            
            

            await ThisMod.InitAsync(); //i think.
            if (ThisMod.MainNickName == "")
                helps.AddNormalTextRow("Main Nick Name", nameof(GlobalDataViewModel.MainNickName));
            else
                helps.AddNormalTextRow("Secondary Nick Name", nameof(GlobalDataViewModel.SecondaryNickName));
            helps.AddNormalTextRow("Azure End Point", nameof(GlobalDataViewModel.AzureEndPointAddress));
            helps.AddNormalTextRow("IP Addresss Of Local Host", nameof(GlobalDataViewModel.HostIPAddress));
            helps.AddGenericButton(System.Windows.Input.Key.F1, ThisMod.ChangeServerOptionsCommand, "Home Hosting", EnumServerMode.HomeHosting);
            helps.AddGenericButton(System.Windows.Input.Key.F2, ThisMod.ChangeServerOptionsCommand, "Azure Hosting", EnumServerMode.AzureHosting);
            helps.AddGenericButton(System.Windows.Input.Key.F3, ThisMod.ChangeServerOptionsCommand, "Local Hosting", EnumServerMode.LocalHosting);
            helps.AddGenericButton(System.Windows.Input.Key.F4, ThisMod.ChangeServerOptionsCommand, "Host In App", EnumServerMode.MobileServer);
            helps.AddGenericButton(System.Windows.Input.Key.F5, ThisMod.DefaultAzureCommand, "Use default azure end point");
            helps.AddLabel("Current Nick Name", nameof(GlobalDataViewModel.CurrentNickName));
            helps.AddLabel("Server Hosting Option", nameof(GlobalDataViewModel.ServerMode), new ServerConverter());
            helps.AddGenericButton(System.Windows.Input.Key.F6, ThisMod.SaveCommand, "Save Settings");
            helps.AddGenericButton(System.Windows.Input.Key.F7, ThisMod.MainNickCommand, "Use Main Nick Name");
            Content = helps.CurrentGrid;
        }
        protected override void RegisterInterfaces()
        {
            OurContainer!.RegisterType<GlobalDataLoaderClass>(true); //this is needed.
            OurContainer.RegisterSingleton<IHostedUIInterface>(this);
        }

        #region Uncommon Overridable Features
        public override void FocusOnFirstControl()
        {
            //if anything is being focused on, doing it here.
        }



        protected override bool HasBorderWhiteBrush()//most of the time, defaults, but can be true (like for gamepackage)
        {
            return base.HasBorderWhiteBrush();
        }

        public override void ShowError(string Message)//if i want different behavior for showing errors, can be done.
        {
            base.ShowError(Message);
        }

        protected override Size DefaultWindowSize()//if i need the size different, can be done.
        {
            return base.DefaultWindowSize();
        }

        protected override void StartUp() //most of the time, nothing but can be put in just in case its needed
        {
            base.StartUp();
        }

        //public NewWindow(Window ThisWindow)
        //{
        //    //ThisPersonal = new BlankPersonal(); //change behavior here.
        //    ThisWindow.Close();
        //    BuildXAML();
        //    this.Show();

        //}

        #endregion





        protected override void AfterViewModel()
        {
            //anything that needs to happen right after creating the view model will happen here.
        }



    }
}
