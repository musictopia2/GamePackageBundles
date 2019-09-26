using CommonBasicStandardLibraries.CollectionClasses;
using CommonBasicStandardLibraries.Exceptions;
using GameLoaderWPF;
using System.Windows;
namespace NonCardOrSolitaireGames.WPF
{
    class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            GameList = new CustomBasicList<string>() { "Blackjack", "Bunco Dice Game", "Froggies", "Mastermind", "Minesweeper", "Poker", "Solitaire Board Game", "XPuzzle"};
        }
        protected override Window ChooseGame(string gameChosen)
        {
            if (gameChosen == "Blackjack")
                return new BlackjackWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Bunco Dice Game")
                return new BuncoDiceGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Froggies")
                return new FroggiesWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Mastermind")
                return new MastermindWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Minesweeper")
                return new MinesweeperWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Poker")
                return new PokerWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Solitaire Board Game")
                return new SolitaireBoardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "XPuzzle")
                return new XPuzzleWPF.GamePage(Starts!, Mode);
            throw new BasicBlankException($"No game found with the game of {gameChosen}");
        }
    }
}