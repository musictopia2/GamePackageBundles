using CommonBasicStandardLibraries.CollectionClasses;
using GameLoaderXF;
using System.Threading.Tasks;
using BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses;
using static BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses.GlobalScreenClass;
namespace PassAndPlayGames
{
    public class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            if (ScreenUsed == EnumScreen.SmallPhone)
                GameList = new CustomBasicList<string>() { "21 Dice Game", "Aggravation", "Backgammon", "Candyland", "Checkers", "Chess", "Chinese Checkers", "Connect Four", "Connect The Dots", "Countdown", "Dead Die 96", "Dice Dominos", "Fill Or Bust", "Kismet", "Mancala", "Pass Out Dice Game", "Roll Em", "Sequence Dice", "Ship Captain Crew", "Sinister Six", "Snakes And Ladders", "Think Twice", "Tic Tac Toe", "Trouble", "Yacht Race", "Yahtzee"};
            else
                GameList = new CustomBasicList<string>() { "21 Dice Game", "Aggravation", "Backgammon", "Bowling Dice Game", "Candyland", "Checkers", "Chess", "Chinese Checkers", "Connect Four", "Connect The Dots", "Countdown", "Dead Die 96", "Dice Dominos", "Fill Or Bust", "Kismet", "Life Board Game", "Mancala", "Pass Out Dice Game", "Payday", "Roll Em", "Sequence Dice", "Ship Captain Crew", "Sinister Six", "Snakes And Ladders", "Sorry", "Think Twice", "Tic Tac Toe", "Trouble", "Yacht Race", "Yahtzee"};
        }
        protected override async Task ChooseAsync()
        {
            if (GameChosen == "21 Dice Game")
                await Navigation!.PushAsync(new A21DiceGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Aggravation")
                await Navigation!.PushAsync(new AggravationXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Backgammon")
                await Navigation!.PushAsync(new BackgammonXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Bowling Dice Game")
                await Navigation!.PushAsync(new BowlingDiceGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Candyland")
                await Navigation!.PushAsync(new CandylandXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Checkers")
                await Navigation!.PushAsync(new CheckersXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Chess")
                await Navigation!.PushAsync(new ChessXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Chinese Checkers")
                await Navigation!.PushAsync(new ChineseCheckersXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Connect Four")
                await Navigation!.PushAsync(new ConnectFourXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Connect The Dots")
                await Navigation!.PushAsync(new ConnectTheDotsXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Countdown")
                await Navigation!.PushAsync(new CountdownXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Dead Die 96")
                await Navigation!.PushAsync(new DeadDie96XF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Dice Dominos")
                await Navigation!.PushAsync(new DiceDominosXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Fill Or Bust")
                await Navigation!.PushAsync(new FillOrBustXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Kismet")
                await Navigation!.PushAsync(new KismetXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Life Board Game")
                await Navigation!.PushAsync(new LifeBoardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Mancala")
                await Navigation!.PushAsync(new MancalaXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Pass Out Dice Game")
                await Navigation!.PushAsync(new PassOutDiceGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Payday")
                await Navigation!.PushAsync(new PaydayXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Roll Em")
                await Navigation!.PushAsync(new RollEmXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Sequence Dice")
                await Navigation!.PushAsync(new SequenceDiceXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Ship Captain Crew")
                await Navigation!.PushAsync(new ShipCaptainCrewXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Sinister Six")
                await Navigation!.PushAsync(new SinisterSixXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Snakes And Ladders")
                await Navigation!.PushAsync(new SnakesAndLaddersXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Sorry")
                await Navigation!.PushAsync(new SorryXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Think Twice")
                await Navigation!.PushAsync(new ThinkTwiceXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Tic Tac Toe")
                await Navigation!.PushAsync(new TicTacToeXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Trouble")
                await Navigation!.PushAsync(new TroubleXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Yacht Race")
                await Navigation!.PushAsync(new YachtRaceXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Yahtzee")
                await Navigation!.PushAsync(new YahtzeeXF.GamePage(Platform!, Starts!, Mode));
        }
    }
}