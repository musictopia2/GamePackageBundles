using BasicGameFramework.CommonInterfaces;
using GameLoaderWPF;
namespace RareSoloGames.WPF
{
    internal class NewWindow : BasicLoaderPage<BasicViewModel>
    {
        public NewWindow(IStartUp starts, bool multiplayer) : base(starts, multiplayer) { Title = "Sample Single Player Loader"; }
    }
}