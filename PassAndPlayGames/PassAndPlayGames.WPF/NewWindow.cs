using BasicGameFramework.CommonInterfaces;
using GameLoaderWPF;
namespace PassAndPlayGames.WPF
{
    internal class NewWindow : BasicLoaderPage<BasicViewModel>
    {
        public NewWindow(IStartUp starts, bool multiplayer) : base(starts, multiplayer) { Title = "Multiplayer Games Sample Loader"; }
    }
}