using CommonBasicStandardLibraries.CollectionClasses;
using CommonBasicStandardLibraries.Exceptions;
using GameLoaderWPF;
using System.Windows;
namespace AllMultiplayerGames.WPF
{
    class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            GameList = new CustomBasicList<string>() { "21 Dice Game", "8 Round Rummy", "Aggravation", "Backgammon", "Battleship", "Bingo", "Blades Of Steel", "Bowling Dice Game", "California Jack", "Candyland", "Checkers", "Chess", "Chinazo", "Chinese Checkers", "Clue Board Game", "Concentration", "Connect Four", "Connect The Dots", "Countdown", "Cousin Rummy", "Crazy Eights", "Cribbage", "Dead Die 96", "Dice Dominos", "Dominos (Mexican Train)", "Dominos (Regular)", "Dummy Rummy", "Dutch Blitz", "Fill Or Bust", "Five Crowns", "Flinch", "Fluxx", "Four Suit Rummy", "Galaxy Card Game", "German Whist", "Go Fish", "Golf Card Game", "Hit The Deck", "Horseshoe", "Huse Hearts", "Italian Dominos", "Kismet", "Life Board Game", "Life Card Game", "Lotto Dominos", "Mancala", "Milk Run", "Millebournes", "Monastery Card Game", "Monopoly Card Game", "Old Maid", "Opetong", "Pass Out Dice Game", "Payday", "Phase 10", "Pickel Card Game", "Pinochle (2 Player)", "Racko", "Rage Card Game", "Roll Em", "Rook", "Rounds Card Game", "Rummy 500", "Rummy Dice", "Sequence Dice", "Ship Captain Crew", "Sinister Six", "Sixty Six (2 Player)", "SkipBo", "Skuck Card Game", "Snag Card Game", "Snakes And Ladders", "Sorry", "Sorry Card Game", "Spades (2 Player)", "Tee It Up", "Think Twice", "Three Letter Fun", "Tic Tac Toe", "Tile Rummy", "Trouble", "Uno", "Xactika", "Yacht Race", "Yahtzee", "Yahtzee Hands Down"};
        }
        protected override Window ChooseGame(string gameChosen)
        {
            if (gameChosen == "21 Dice Game")
                return new A21DiceGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "8 Round Rummy")
                return new A8RoundRummyWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Aggravation")
                return new AggravationWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Backgammon")
                return new BackgammonWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Battleship")
                return new BattleshipWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Bingo")
                return new BingoWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Blades Of Steel")
                return new BladesOfSteelWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Bowling Dice Game")
                return new BowlingDiceGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "California Jack")
                return new CaliforniaJackWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Candyland")
                return new CandylandWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Checkers")
                return new CheckersWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Chess")
                return new ChessWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Chinazo")
                return new ChinazoWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Chinese Checkers")
                return new ChineseCheckersWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Clue Board Game")
                return new ClueBoardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Concentration")
                return new ConcentrationWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Connect Four")
                return new ConnectFourWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Connect The Dots")
                return new ConnectTheDotsWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Countdown")
                return new CountdownWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Cousin Rummy")
                return new CousinRummyWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Crazy Eights")
                return new CrazyEightsWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Cribbage")
                return new CribbageWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Dead Die 96")
                return new DeadDie96WPF.GamePage(Starts!, Mode);
            if (gameChosen == "Dice Dominos")
                return new DiceDominosWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Dominos (Mexican Train)")
                return new DominosMexicanTrainWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Dominos (Regular)")
                return new DominosRegularWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Dummy Rummy")
                return new DummyRummyWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Dutch Blitz")
                return new DutchBlitzWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Fill Or Bust")
                return new FillOrBustWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Five Crowns")
                return new FiveCrownsWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Flinch")
                return new FlinchWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Fluxx")
                return new FluxxWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Four Suit Rummy")
                return new FourSuitRummyWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Galaxy Card Game")
                return new GalaxyCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "German Whist")
                return new GermanWhistWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Go Fish")
                return new GoFishWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Golf Card Game")
                return new GolfCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Hit The Deck")
                return new HitTheDeckWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Horseshoe")
                return new HorseshoeCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Huse Hearts")
                return new HuseHeartsWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Italian Dominos")
                return new ItalianDominosWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Kismet")
                return new KismetWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Life Board Game")
                return new LifeBoardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Life Card Game")
                return new LifeCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Lotto Dominos")
                return new LottoDominosWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Mancala")
                return new MancalaWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Milk Run")
                return new MilkRunWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Millebournes")
                return new MillebournesWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Monastery Card Game")
                return new MonasteryCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Monopoly Card Game")
                return new MonopolyCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Old Maid")
                return new OldMaidWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Opetong")
                return new OpetongWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Pass Out Dice Game")
                return new PassOutDiceGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Payday")
                return new PaydayWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Phase 10")
                return new Phase10WPF.GamePage(Starts!, Mode);
            if (gameChosen == "Pickel Card Game")
                return new PickelCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Pinochle (2 Player)")
                return new Pinochle2PlayerWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Racko")
                return new RackoWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Rage Card Game")
                return new RageCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Roll Em")
                return new RollEmWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Rook")
                return new RookWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Rounds Card Game")
                return new RoundsCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Rummy 500")
                return new Rummy500WPF.GamePage(Starts!, Mode);
            if (gameChosen == "Rummy Dice")
                return new RummyDiceWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Sequence Dice")
                return new SequenceDiceWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Ship Captain Crew")
                return new ShipCaptainCrewWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Sinister Six")
                return new SinisterSixWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Sixty Six (2 Player)")
                return new SixtySix2PlayerWPF.GamePage(Starts!, Mode);
            if (gameChosen == "SkipBo")
                return new SkipboWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Skuck Card Game")
                return new SkuckCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Snag Card Game")
                return new SnagCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Snakes And Ladders")
                return new SnakesAndLaddersWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Sorry")
                return new SorryWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Sorry Card Game")
                return new SorryCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Spades (2 Player)")
                return new Spades2PlayerWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Tee It Up")
                return new TeeItUpWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Think Twice")
                return new ThinkTwiceWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Three Letter Fun")
                return new ThreeLetterFunWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Tic Tac Toe")
                return new TicTacToeWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Tile Rummy")
                return new TileRummyWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Trouble")
                return new TroubleWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Uno")
                return new UnoWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Xactika")
                return new XactikaWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Yacht Race")
                return new YachtRaceWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Yahtzee")
                return new YahtzeeWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Yahtzee Hands Down")
                return new YahtzeeHandsDownWPF.GamePage(Starts!, Mode);
            throw new BasicBlankException($"No game found with the game of {gameChosen}");
        }
    }
}