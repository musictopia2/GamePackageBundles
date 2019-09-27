using CommonBasicStandardLibraries.CollectionClasses;
using CommonBasicStandardLibraries.Exceptions;
using GameLoaderWPF;
using System.Windows;
namespace FirstTestLoader.WPF
{
    class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            GameList = new CustomBasicList<string>() { "Blades Of Steel", "Millebournes", "Opetong", "Tile Rummy"};
        }
        protected override Window ChooseGame(string gameChosen)
        {
            if (gameChosen == "Blades Of Steel")
                return new BladesOfSteelWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Millebournes")
                return new MillebournesWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Opetong")
                return new OpetongWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Tile Rummy")
                return new TileRummyWPF.GamePage(Starts!, Mode);
            throw new BasicBlankException($"No game found with the game of {gameChosen}");
        }
    }
}