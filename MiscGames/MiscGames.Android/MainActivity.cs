using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using BasicGameFramework.StandardImplementations.XamarinForms.Interfaces;
using GameLoaderXF;
using BasicGameFramework.CommonInterfaces;
using Android;
using BasicGameFramework.DIContainers;
using BasicGameFramework.StandardImplementations.XamarinForms.BasicClasses;
using BasicGameFramework.BasicGameDataClasses;
using static BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses.GlobalScreenClass;
using BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses;
using CommonBasicStandardLibraries.Exceptions;

namespace MiscGames.Droid
{
    [Activity(Label = "MiscGames", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity, IGamePlatform, IForceOrientation, IScreen
    {
        private void CheckAppPermissions()
        {
            if ((int)Build.VERSION.SdkInt < 23)
            {
                return;
            }
            else
            {
                if (PackageManager.CheckPermission(Manifest.Permission.ReadExternalStorage, PackageName) != Permission.Granted
                    && PackageManager.CheckPermission(Manifest.Permission.WriteExternalStorage, PackageName) != Permission.Granted)
                {
                    var permissions = new string[] { Manifest.Permission.ReadExternalStorage, Manifest.Permission.WriteExternalStorage };
                    RequestPermissions(permissions, 1);
                }
            }
        }
        void IGamePlatform.CloseApp()
        {
            Process.KillProcess(Process.MyPid());
        }
        void IGamePlatform.SetUp(GamePackageDIContainer container)
        {
            container.RegisterType<CustomScreenProcesses>();
            container.RegisterType<StandardButtonFontClass>();
            container.RegisterSingleton(this);
        }
        private void SetUI()
        {
            int uiOptions = (int)Window.DecorView.SystemUiVisibility;
            uiOptions |= (int)SystemUiFlags.LowProfile;
            uiOptions |= (int)SystemUiFlags.Fullscreen;
            uiOptions |= (int)SystemUiFlags.HideNavigation;
            uiOptions |= (int)SystemUiFlags.ImmersiveSticky;
            Window.DecorView.SystemUiVisibility = (StatusBarVisibility)uiOptions;
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            SetUI();
            CheckAppPermissions();
            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App(this, this, this));
        }
        protected override void OnStart()
        {
            SetUI();
            base.OnStart();
        }
        protected override void OnResume()
        {
            SetUI();
            base.OnResume();
        }
        void IGamePlatform.SupportedOrientation(IGameInfo game)
        {

            if (game.SuggestedOrientation == EnumSuggestedOrientation.Landscape)
                RequestedOrientation = ScreenOrientation.Landscape;
            else
                RequestedOrientation = ScreenOrientation.Portrait;

        }
        void IGamePlatform.ResetPopups()
        {
            SetUI();
        }
        void IForceOrientation.ForceOrientation()
        {
            RequestedOrientation = ScreenOrientation.Landscape;
        }

        void IScreen.CalculateScreens()
        {
            var screenHeight = (int)(Resources.DisplayMetrics.HeightPixels / Resources.DisplayMetrics.Density);
            var screenWidth = (int)(Resources.DisplayMetrics.WidthPixels / Resources.DisplayMetrics.Density);
            if (screenHeight > 1100 || screenWidth > 1100)
                ScreenUsed = EnumScreen.LargeTablet;
            else if (screenHeight < 700 || screenWidth < 700)
                ScreenUsed = EnumScreen.SmallPhone;
            else
                throw new BasicBlankException("Unknown for now");
        }
    }
}