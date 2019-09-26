using BasicGameFramework.CommonInterfaces;
using BasicGameFramework.StandardImplementations.CrossPlatform.MiscClasses;
using BasicGameFramework.StandardImplementations.XamarinForms.Interfaces;
using GameLoaderXF;
using Xamarin.Forms;
namespace AndyFavoriteSoloGames
{
    public class App : Application
    {
        public App(IGamePlatform platform, IForceOrientation forces, IScreen screen)
        {
            IStartUp starts = new SinglePlayerStartUpClass();
            MainPage = new NavigationPage(new StartPage(platform, starts, forces, screen, false));
        }
    }
}