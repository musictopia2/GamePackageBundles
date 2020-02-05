using BasicGameFramework.CommonInterfaces;
using BasicGameFramework.StandardImplementations.XamarinForms.Interfaces;
using GameLoaderXF;
namespace TrickTakingGames
{
    public class StartPage : BasicLoaderPage<BasicViewModel>
    {
        public StartPage(IGamePlatform platform, IStartUp starts, IForceOrientation forces, IScreen screen, bool multiPlayer) : base(platform, starts, forces, screen, multiPlayer) { }
    }
}