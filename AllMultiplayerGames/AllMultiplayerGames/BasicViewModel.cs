using CommonBasicStandardLibraries.CollectionClasses;
using GameLoaderXF;
using System.Threading.Tasks;
using BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses;
using static BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses.GlobalScreenClass;
namespace AllMultiplayerGames
{
    public class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            if (ScreenUsed == EnumScreen.SmallPhone)
                GameList = new CustomBasicList<string>() { "21 Dice Game", "Aggravation", "Backgammon", "Bingo", "California Jack", "Candyland", "Checkers", "Chess", "Chinese Checkers", "Concentration", "Connect Four", "Connect The Dots", "Countdown", "Crazy Eights", "Dead Die 96", "Dice Dominos", "Dominos (Regular)", "Dutch Blitz", "Fill Or Bust", "Flinch", "German Whist", "Italian Dominos", "Kismet", "Life Card Game", "Lotto Dominos", "Mancala", "Millebournes", "Opetong", "Pass Out Dice Game", "Roll Em", "Sequence Dice", "Ship Captain Crew", "Sinister Six", "SkipBo", "Snakes And Ladders", "Tee It Up", "Think Twice", "Three Letter Fun", "Tic Tac Toe", "Trouble", "Uno", "Yacht Race", "Yahtzee"};
            else
                GameList = new CustomBasicList<string>() { "21 Dice Game", "8 Round Rummy", "Aggravation", "Backgammon", "Battleship", "Bingo", "Blades Of Steel", "Bowling Dice Game", "California Jack", "Candyland", "Checkers", "Chess", "Chinazo", "Chinese Checkers", "Clue Board Game", "Concentration", "Connect Four", "Connect The Dots", "Countdown", "Cousin Rummy", "Crazy Eights", "Cribbage", "Dead Die 96", "Dice Dominos", "Dominos (Regular)", "Dummy Rummy", "Dutch Blitz", "Fill Or Bust", "Five Crowns", "Flinch", "Fluxx", "Four Suit Rummy", "Galaxy Card Game", "German Whist", "Go Fish", "Golf Card Game", "Hit The Deck", "Horseshoe", "Huse Hearts", "Italian Dominos", "Kismet", "Life Board Game", "Life Card Game", "Lotto Dominos", "Mancala", "Milk Run", "Millebournes", "Monastery Card Game", "Monopoly Card Game", "Old Maid", "Opetong", "Pass Out Dice Game", "Payday", "Phase 10", "Pickel Card Game", "Pinochle (2 Player)", "Racko", "Rage Card Game", "Roll Em", "Rook", "Rounds Card Game", "Rummy 500", "Rummy Dice", "Sequence Dice", "Ship Captain Crew", "Sinister Six", "Sixty Six (2 Player)", "SkipBo", "Skuck Card Game", "Snag Card Game", "Snakes And Ladders", "Sorry", "Sorry Card Game", "Spades (2 Player)", "Tee It Up", "Think Twice", "Three Letter Fun", "Tic Tac Toe", "Tile Rummy", "Trouble", "Uno", "Xactika", "Yacht Race", "Yahtzee", "Yahtzee Hands Down"};
        }
        protected override async Task ChooseAsync()
        {
            if (GameChosen == "21 Dice Game")
                await Navigation!.PushAsync(new A21DiceGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "8 Round Rummy")
                await Navigation!.PushAsync(new A8RoundRummyXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Aggravation")
                await Navigation!.PushAsync(new AggravationXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Backgammon")
                await Navigation!.PushAsync(new BackgammonXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Battleship")
                await Navigation!.PushAsync(new BattleshipXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Bingo")
                await Navigation!.PushAsync(new BingoXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Blades Of Steel")
                await Navigation!.PushAsync(new BladesOfSteelXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Bowling Dice Game")
                await Navigation!.PushAsync(new BowlingDiceGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "California Jack")
                await Navigation!.PushAsync(new CaliforniaJackXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Candyland")
                await Navigation!.PushAsync(new CandylandXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Checkers")
                await Navigation!.PushAsync(new CheckersXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Chess")
                await Navigation!.PushAsync(new ChessXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Chinazo")
                await Navigation!.PushAsync(new ChinazoXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Chinese Checkers")
                await Navigation!.PushAsync(new ChineseCheckersXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Clue Board Game")
                await Navigation!.PushAsync(new ClueBoardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Concentration")
                await Navigation!.PushAsync(new ConcentrationXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Connect Four")
                await Navigation!.PushAsync(new ConnectFourXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Connect The Dots")
                await Navigation!.PushAsync(new ConnectTheDotsXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Countdown")
                await Navigation!.PushAsync(new CountdownXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Cousin Rummy")
                await Navigation!.PushAsync(new CousinRummyXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Crazy Eights")
                await Navigation!.PushAsync(new CrazyEightsXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Cribbage")
                await Navigation!.PushAsync(new CribbageXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Dead Die 96")
                await Navigation!.PushAsync(new DeadDie96XF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Dice Dominos")
                await Navigation!.PushAsync(new DiceDominosXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Dominos (Mexican Train)")
                await Navigation!.PushAsync(new DominosMexicanTrainXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Dominos (Regular)")
                await Navigation!.PushAsync(new DominosRegularXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Dummy Rummy")
                await Navigation!.PushAsync(new DummyRummyXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Dutch Blitz")
                await Navigation!.PushAsync(new DutchBlitzXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Fill Or Bust")
                await Navigation!.PushAsync(new FillOrBustXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Five Crowns")
                await Navigation!.PushAsync(new FiveCrownsXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Flinch")
                await Navigation!.PushAsync(new FlinchXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Fluxx")
                await Navigation!.PushAsync(new FluxxXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Four Suit Rummy")
                await Navigation!.PushAsync(new FourSuitRummyXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Galaxy Card Game")
                await Navigation!.PushAsync(new GalaxyCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "German Whist")
                await Navigation!.PushAsync(new GermanWhistXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Go Fish")
                await Navigation!.PushAsync(new GoFishXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Golf Card Game")
                await Navigation!.PushAsync(new GolfCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Hit The Deck")
                await Navigation!.PushAsync(new HitTheDeckXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Horseshoe")
                await Navigation!.PushAsync(new HorseshoeCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Huse Hearts")
                await Navigation!.PushAsync(new HuseHeartsXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Italian Dominos")
                await Navigation!.PushAsync(new ItalianDominosXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Kismet")
                await Navigation!.PushAsync(new KismetXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Life Board Game")
                await Navigation!.PushAsync(new LifeBoardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Life Card Game")
                await Navigation!.PushAsync(new LifeCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Lotto Dominos")
                await Navigation!.PushAsync(new LottoDominosXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Mancala")
                await Navigation!.PushAsync(new MancalaXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Milk Run")
                await Navigation!.PushAsync(new MilkRunXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Millebournes")
                await Navigation!.PushAsync(new MillebournesXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Monastery Card Game")
                await Navigation!.PushAsync(new MonasteryCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Monopoly Card Game")
                await Navigation!.PushAsync(new MonopolyCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Old Maid")
                await Navigation!.PushAsync(new OldMaidXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Opetong")
                await Navigation!.PushAsync(new OpetongXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Pass Out Dice Game")
                await Navigation!.PushAsync(new PassOutDiceGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Payday")
                await Navigation!.PushAsync(new PaydayXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Phase 10")
                await Navigation!.PushAsync(new Phase10XF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Pickel Card Game")
                await Navigation!.PushAsync(new PickelCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Pinochle (2 Player)")
                await Navigation!.PushAsync(new Pinochle2PlayerXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Racko")
                await Navigation!.PushAsync(new RackoXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Rage Card Game")
                await Navigation!.PushAsync(new RageCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Roll Em")
                await Navigation!.PushAsync(new RollEmXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Rook")
                await Navigation!.PushAsync(new RookXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Rounds Card Game")
                await Navigation!.PushAsync(new RoundsCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Rummy 500")
                await Navigation!.PushAsync(new Rummy500XF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Rummy Dice")
                await Navigation!.PushAsync(new RummyDiceXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Sequence Dice")
                await Navigation!.PushAsync(new SequenceDiceXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Ship Captain Crew")
                await Navigation!.PushAsync(new ShipCaptainCrewXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Sinister Six")
                await Navigation!.PushAsync(new SinisterSixXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Sixty Six (2 Player)")
                await Navigation!.PushAsync(new SixtySix2PlayerXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "SkipBo")
                await Navigation!.PushAsync(new SkipboXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Skuck Card Game")
                await Navigation!.PushAsync(new SkuckCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Snag Card Game")
                await Navigation!.PushAsync(new SnagCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Snakes And Ladders")
                await Navigation!.PushAsync(new SnakesAndLaddersXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Sorry")
                await Navigation!.PushAsync(new SorryXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Sorry Card Game")
                await Navigation!.PushAsync(new SorryCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Spades (2 Player)")
                await Navigation!.PushAsync(new Spades2PlayerXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Tee It Up")
                await Navigation!.PushAsync(new TeeItUpXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Think Twice")
                await Navigation!.PushAsync(new ThinkTwiceXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Three Letter Fun")
                await Navigation!.PushAsync(new ThreeLetterFunXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Tic Tac Toe")
                await Navigation!.PushAsync(new TicTacToeXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Tile Rummy")
                await Navigation!.PushAsync(new TileRummyXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Trouble")
                await Navigation!.PushAsync(new TroubleXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Uno")
                await Navigation!.PushAsync(new UnoXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Xactika")
                await Navigation!.PushAsync(new XactikaXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Yacht Race")
                await Navigation!.PushAsync(new YachtRaceXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Yahtzee")
                await Navigation!.PushAsync(new YahtzeeXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Yahtzee Hands Down")
                await Navigation!.PushAsync(new YahtzeeHandsDownXF.GamePage(Platform!, Starts!, Mode));
        }
    }
}