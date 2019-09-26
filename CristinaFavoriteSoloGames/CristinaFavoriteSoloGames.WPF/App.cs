using BasicGameFramework.CommonInterfaces;
using BasicGameFramework.StandardImplementations.CrossPlatform.MiscClasses;
using System;
using System.Windows;
namespace CristinaFavoriteSoloGames.WPF
{
    public sealed partial class App : Application
    {
        static App()
        { }
        public App()
        { }
        protected override void OnStartup(StartupEventArgs e)
        {
            //this means i could decide to not even override but instead go directly to another class to do the work.  that is very good to know.
            IStartUp starts = new SinglePlayerStartUpClass();
            MainWindow = new NewWindow(starts, false); //hopefully that is it this time.
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