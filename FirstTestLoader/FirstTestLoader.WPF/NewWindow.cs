using BasicGameFramework.CommonInterfaces;
using GameLoaderWPF;
namespace FirstTestLoader.WPF
{
    internal class NewWindow : BasicLoaderPage<BasicViewModel>
    {
        public NewWindow(IStartUp starts, bool multiplayer) : base(starts, multiplayer) { Title = "First Test Loader"; }
    }
}