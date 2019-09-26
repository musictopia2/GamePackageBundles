using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android;
using BasicGameFramework.StandardImplementations.XamarinForms.Interfaces;
using BasicGameFramework.BasicGameDataClasses;
using BasicGameFramework.DIContainers;

namespace GamePackageSettingsApp.Droid
{
    [Activity(Label = "GamePackageSettingsApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity, IGamePlatform
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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            CheckAppPermissions();
            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App(this));
        }

        void IGamePlatform.CloseApp()
        {
            Process.KillProcess(Process.MyPid());
        }

        void IGamePlatform.SupportedOrientation(IGameInfo game)
        {
            //this should not need to do anything.
        }

        void IGamePlatform.SetUp(GamePackageDIContainer container)
        {
            
        }

        void IGamePlatform.ResetPopups()
        {
            
        }
    }
}