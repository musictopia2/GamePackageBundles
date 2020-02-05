using CommonBasicStandardLibraries.CollectionClasses;
using CommonBasicStandardLibraries.Exceptions;
using GameLoaderWPF;
using System.Windows;
namespace RummyGames.WPF
{
    class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            GameList = new CustomBasicList<string>() { "8 Round Rummy", "Chinazo", "Cousin Rummy", "Dummy Rummy", "Five Crowns", "Four Suit Rummy", "Galaxy Card Game", "Monastery Card Game", "Opetong", "Phase 10", "Rummy 500", "Rummy Dice", "Tile Rummy"};
        }
        protected override Window ChooseGame(string gameChosen)
        {
            if (gameChosen == "8 Round Rummy")
                return new A8RoundRummyWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Chinazo")
                return new ChinazoWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Cousin Rummy")
                return new CousinRummyWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Dummy Rummy")
                return new DummyRummyWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Five Crowns")
                return new FiveCrownsWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Four Suit Rummy")
                return new FourSuitRummyWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Galaxy Card Game")
                return new GalaxyCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Monastery Card Game")
                return new MonasteryCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Opetong")
                return new OpetongWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Phase 10")
                return new Phase10WPF.GamePage(Starts!, Mode);
            if (gameChosen == "Rummy 500")
                return new Rummy500WPF.GamePage(Starts!, Mode);
            if (gameChosen == "Rummy Dice")
                return new RummyDiceWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Tile Rummy")
                return new TileRummyWPF.GamePage(Starts!, Mode);
            throw new BasicBlankException($"No game found with the game of {gameChosen}");
        }
    }
}