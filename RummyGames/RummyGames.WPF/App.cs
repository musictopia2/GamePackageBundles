using BasicGameFramework.CommonInterfaces;
using GamePackageSignalRClasses;
using System;
using System.Windows;
namespace RummyGames.WPF
{
    public sealed partial class App : Application
    {
        static App()
        { }

        public App()
        { }

        protected override void OnStartup(StartupEventArgs e)
        {
            IStartUp starts = new MainStartUp();
            MainWindow = new NewWindow(starts, true); //hopefully that is it this time.
        }

        [STAThread]
        public static int Main()
        {
            App app = new App();
            app.Run();
            return 0;
        }
    }
}