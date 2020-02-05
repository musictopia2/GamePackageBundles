using CommonBasicStandardLibraries.CollectionClasses;
using CommonBasicStandardLibraries.Exceptions;
using GameLoaderWPF;
using System.Windows;
namespace BoardGames.WPF
{
    class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            GameList = new CustomBasicList<string>() { "Aggravation", "Backgammon", "Candyland", "Clue Board Game", "Life Board Game", "Payday", "Sorry", "Trouble"};
        }
        protected override Window ChooseGame(string gameChosen)
        {
            if (gameChosen == "Aggravation")
                return new AggravationWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Backgammon")
                return new BackgammonWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Candyland")
                return new CandylandWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Clue Board Game")
                return new ClueBoardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Life Board Game")
                return new LifeBoardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Payday")
                return new PaydayWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Sorry")
                return new SorryWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Trouble")
                return new TroubleWPF.GamePage(Starts!, Mode);
            throw new BasicBlankException($"No game found with the game of {gameChosen}");
        }
    }
}