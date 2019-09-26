using CommonBasicStandardLibraries.CollectionClasses;
using CommonBasicStandardLibraries.Exceptions;
using GameLoaderWPF;
using System.Windows;
namespace CristinaFavoriteSoloGames.WPF
{
    class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            GameList = new CustomBasicList<string>() { "Blackjack", "Clock Solitaire", "Carpet Solitaire", "Easy Go Solitaire", "Froggies", "Klondike Solitaire", "MahJong Solitaire", "Mastermind", "Spider Solitaire"};
        }
        protected override Window ChooseGame(string gameChosen)
        {
            if (gameChosen == "Blackjack")
                return new BlackjackWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Clock Solitaire")
                return new ClockSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Carpet Solitaire")
                return new CarpetSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Easy Go Solitaire")
                return new EasyGoSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Froggies")
                return new FroggiesWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Klondike Solitaire")
                return new KlondikeSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "MahJong Solitaire")
                return new MahJongSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Mastermind")
                return new MastermindWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Spider Solitaire")
                return new SpiderSolitaireWPF.GamePage(Starts!, Mode);
            throw new BasicBlankException($"No game found with the game of {gameChosen}");
        }
    }
}