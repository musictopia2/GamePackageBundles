using CommonBasicStandardLibraries.CollectionClasses;
using CommonBasicStandardLibraries.Exceptions;
using GameLoaderWPF;
using System.Windows;
namespace AndyFavoriteSoloGames.WPF
{
    class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            GameList = new CustomBasicList<string>() { "MahJong Solitaire", "Klondike Solitaire", "Bisley Solitaire", "Florentine Solitaire", "Free Cell Solitaire", "Bakers Dozen Solitaire", "Beleagured Castle", "Eight Off Solitaire", "Spider Solitaire", "Martha Solitaire", "Persian Solitaire", "Grandfather's Clock", "Pyramid Solitaire"};
        }
        protected override Window ChooseGame(string gameChosen)
        {
            if (gameChosen == "MahJong Solitaire")
                return new MahJongSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Klondike Solitaire")
                return new KlondikeSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Bisley Solitaire")
                return new BisleySolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Florentine Solitaire")
                return new FlorentineSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Free Cell Solitaire")
                return new FreeCellSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Bakers Dozen Solitaire")
                return new BakersDozenSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Beleagured Castle")
                return new BeleaguredCastleWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Eight Off Solitaire")
                return new EightOffSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Spider Solitaire")
                return new SpiderSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Martha Solitaire")
                return new MarthaSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Persian Solitaire")
                return new PersianSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Grandfather's Clock")
                return new GrandfathersClockWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Pyramid Solitaire")
                return new PyramidSolitaireWPF.GamePage(Starts!, Mode);
            throw new BasicBlankException($"No game found with the game of {gameChosen}");
        }
    }
}