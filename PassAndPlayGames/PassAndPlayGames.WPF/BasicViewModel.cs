using CommonBasicStandardLibraries.CollectionClasses;
using CommonBasicStandardLibraries.Exceptions;
using GameLoaderWPF;
using System.Windows;
namespace PassAndPlayGames.WPF
{
    class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            GameList = new CustomBasicList<string>() { "21 Dice Game", "Aggravation", "Backgammon", "Bowling Dice Game", "Candyland", "Checkers", "Chess", "Chinese Checkers", "Connect Four", "Connect The Dots", "Countdown", "Dead Die 96", "Dice Dominos", "Fill Or Bust", "Kismet", "Life Board Game", "Mancala", "Pass Out Dice Game", "Payday", "Roll Em", "Sequence Dice", "Ship Captain Crew", "Sinister Six", "Snakes And Ladders", "Sorry", "Think Twice", "Tic Tac Toe", "Trouble", "Yacht Race", "Yahtzee"};
        }
        protected override Window ChooseGame(string gameChosen)
        {
            if (gameChosen == "21 Dice Game")
                return new A21DiceGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Aggravation")
                return new AggravationWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Backgammon")
                return new BackgammonWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Bowling Dice Game")
                return new BowlingDiceGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Candyland")
                return new CandylandWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Checkers")
                return new CheckersWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Chess")
                return new ChessWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Chinese Checkers")
                return new ChineseCheckersWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Connect Four")
                return new ConnectFourWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Connect The Dots")
                return new ConnectTheDotsWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Countdown")
                return new CountdownWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Dead Die 96")
                return new DeadDie96WPF.GamePage(Starts!, Mode);
            if (gameChosen == "Dice Dominos")
                return new DiceDominosWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Fill Or Bust")
                return new FillOrBustWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Kismet")
                return new KismetWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Life Board Game")
                return new LifeBoardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Mancala")
                return new MancalaWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Pass Out Dice Game")
                return new PassOutDiceGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Payday")
                return new PaydayWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Roll Em")
                return new RollEmWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Sequence Dice")
                return new SequenceDiceWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Ship Captain Crew")
                return new ShipCaptainCrewWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Sinister Six")
                return new SinisterSixWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Snakes And Ladders")
                return new SnakesAndLaddersWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Sorry")
                return new SorryWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Think Twice")
                return new ThinkTwiceWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Tic Tac Toe")
                return new TicTacToeWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Trouble")
                return new TroubleWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Yacht Race")
                return new YachtRaceWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Yahtzee")
                return new YahtzeeWPF.GamePage(Starts!, Mode);
            throw new BasicBlankException($"No game found with the game of {gameChosen}");
        }
    }
}