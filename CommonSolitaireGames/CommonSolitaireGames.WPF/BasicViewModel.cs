using CommonBasicStandardLibraries.CollectionClasses;
using CommonBasicStandardLibraries.Exceptions;
using GameLoaderWPF;
using System.Windows;
namespace CommonSolitaireGames.WPF
{
    class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            GameList = new CustomBasicList<string>() { "Carpet Solitaire", "Clock Solitaire", "Cribbage Patience", "Eagle Wings Solitaire", "Easy Go Solitaire", "Heap Solitaire", "Triangle Solitaire", "Vegas Solitaire"};
        }
        protected override Window ChooseGame(string gameChosen)
        {
            if (gameChosen == "Carpet Solitaire")
                return new CarpetSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Clock Solitaire")
                return new ClockSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Cribbage Patience")
                return new CribbagePatienceWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Eagle Wings Solitaire")
                return new EagleWingsSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Easy Go Solitaire")
                return new EasyGoSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Heap Solitaire")
                return new HeapSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Triangle Solitaire")
                return new TriangleSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Vegas Solitaire")
                return new VegasSolitaireWPF.GamePage(Starts!, Mode);
            throw new BasicBlankException($"No game found with the game of {gameChosen}");
        }
    }
}