namespace AllMultiplayerGames.WebAssembly;
public class BasicViewModel(IStartUp starts) : LoaderViewModel(starts)
{
    public override string Title => "AllMultiplayerGames.WebAssembly";
    protected override void GenerateGameList()
    {
        GameList = [ "A21DiceGame", "A8RoundRummy", "Aggravation", "Backgammon", "Battleship", "BattleshipLite", "Bingo", "BladesOfSteel", "BowlingDiceGame", "CaliforniaJack", "Candyland", "Checkers", "Chess", "Chinazo", "ChineseCheckers", "ClueBoardGame", "Concentration", "ConnectFour", "ConnectTheDots", "Countdown", "CousinRummy", "CoveredUp", "CrazyEights", "Cribbage", "DeadDie96", "DiceDominos", "DominosMexicanTrain", "DominosRegular", "DummyRummy", "DutchBlitz", "FillOrBust", "FiveCrowns", "Flinch", "Fluxx", "FourSuitRummy", "GalaxyCardGame", "GermanWhist", "GoFish", "GolfCardGame", "Hearts", "HitTheDeck", "HorseshoeCardGame", "HuseHearts", "ItalianDominos", "Kismet", "LifeBoardGame", "LifeCardGame", "LottoDominos", "Mancala", "MilkRun", "Millebournes", "MonasteryCardGame", "MonopolyCardGame", "MonopolyDicedGame", "OldMaid", "Opetong", "PassOutDiceGame", "Payday", "Phase10", "PickelCardGame", "Pinochle2Player", "Racko", "RageCardGame", "Risk", "RollEm", "Rook", "RoundsCardGame", "Rummy500", "RummyDice", "Savannah", "SequenceDice", "ShipCaptainCrew", "SinisterSix", "SixtySix2Player", "Skipbo", "SkuckCardGame", "SnagCardGame", "SnakesAndLadders", "Sorry", "SorryCardGame", "Spades4Player", "Spades2Player", "TeeItUp", "ThinkTwice", "ThreeLetterFun", "TicTacToe", "TileRummy", "Trouble", "Uno", "Xactika", "YaBlewIt", "YachtRace", "Yahtzee", "YahtzeeHandsDown"];
    }
    protected override Type GetGameType()
    {
        if (GameName == "A21DiceGame")
        {
            return typeof(A21DiceGame.Blazor.Index);
        }
        if (GameName == "A8RoundRummy")
        {
            return typeof(A8RoundRummy.Blazor.Index);
        }
        if (GameName == "Aggravation")
        {
            return typeof(Aggravation.Blazor.Index);
        }
        if (GameName == "Backgammon")
        {
            return typeof(Backgammon.Blazor.Index);
        }
        if (GameName == "Battleship")
        {
            return typeof(Battleship.Blazor.Index);
        }
        if (GameName == "BattleshipLite")
        {
            return typeof(BattleshipLite.Blazor.Index);
        }
        if (GameName == "Bingo")
        {
            return typeof(Bingo.Blazor.Index);
        }
        if (GameName == "BladesOfSteel")
        {
            return typeof(BladesOfSteel.Blazor.Index);
        }
        if (GameName == "BowlingDiceGame")
        {
            return typeof(BowlingDiceGame.Blazor.Index);
        }
        if (GameName == "CaliforniaJack")
        {
            return typeof(CaliforniaJack.Blazor.Index);
        }
        if (GameName == "Candyland")
        {
            return typeof(Candyland.Blazor.Index);
        }
        if (GameName == "Checkers")
        {
            return typeof(Checkers.Blazor.Index);
        }
        if (GameName == "Chess")
        {
            return typeof(Chess.Blazor.Index);
        }
        if (GameName == "Chinazo")
        {
            return typeof(Chinazo.Blazor.Index);
        }
        if (GameName == "ChineseCheckers")
        {
            return typeof(ChineseCheckers.Blazor.Index);
        }
        if (GameName == "ClueBoardGame")
        {
            return typeof(ClueBoardGame.Blazor.Index);
        }
        if (GameName == "Concentration")
        {
            return typeof(Concentration.Blazor.Index);
        }
        if (GameName == "ConnectFour")
        {
            return typeof(ConnectFour.Blazor.Index);
        }
        if (GameName == "ConnectTheDots")
        {
            return typeof(ConnectTheDots.Blazor.Index);
        }
        if (GameName == "Countdown")
        {
            return typeof(Countdown.Blazor.Index);
        }
        if (GameName == "CousinRummy")
        {
            return typeof(CousinRummy.Blazor.Index);
        }
        if (GameName == "CoveredUp")
        {
            return typeof(CoveredUp.Blazor.Index);
        }
        if (GameName == "CrazyEights")
        {
            return typeof(CrazyEights.Blazor.Index);
        }
        if (GameName == "Cribbage")
        {
            return typeof(Cribbage.Blazor.Index);
        }
        if (GameName == "DeadDie96")
        {
            return typeof(DeadDie96.Blazor.Index);
        }
        if (GameName == "DiceDominos")
        {
            return typeof(DiceDominos.Blazor.Index);
        }
        if (GameName == "DominosMexicanTrain")
        {
            return typeof(DominosMexicanTrain.Blazor.Index);
        }
        if (GameName == "DominosRegular")
        {
            return typeof(DominosRegular.Blazor.Index);
        }
        if (GameName == "DummyRummy")
        {
            return typeof(DummyRummy.Blazor.Index);
        }
        if (GameName == "DutchBlitz")
        {
            return typeof(DutchBlitz.Blazor.Index);
        }
        if (GameName == "FillOrBust")
        {
            return typeof(FillOrBust.Blazor.Index);
        }
        if (GameName == "FiveCrowns")
        {
            return typeof(FiveCrowns.Blazor.Index);
        }
        if (GameName == "Flinch")
        {
            return typeof(Flinch.Blazor.Index);
        }
        if (GameName == "Fluxx")
        {
            return typeof(Fluxx.Blazor.Index);
        }
        if (GameName == "FourSuitRummy")
        {
            return typeof(FourSuitRummy.Blazor.Index);
        }
        if (GameName == "GalaxyCardGame")
        {
            return typeof(GalaxyCardGame.Blazor.Index);
        }
        if (GameName == "GermanWhist")
        {
            return typeof(GermanWhist.Blazor.Index);
        }
        if (GameName == "GoFish")
        {
            return typeof(GoFish.Blazor.Index);
        }
        if (GameName == "GolfCardGame")
        {
            return typeof(GolfCardGame.Blazor.Index);
        }
        if (GameName == "Hearts")
        {
            return typeof(Hearts.Blazor.Index);
        }
        if (GameName == "HitTheDeck")
        {
            return typeof(HitTheDeck.Blazor.Index);
        }
        if (GameName == "HorseshoeCardGame")
        {
            return typeof(HorseshoeCardGame.Blazor.Index);
        }
        if (GameName == "HuseHearts")
        {
            return typeof(HuseHearts.Blazor.Index);
        }
        if (GameName == "ItalianDominos")
        {
            return typeof(ItalianDominos.Blazor.Index);
        }
        if (GameName == "Kismet")
        {
            return typeof(Kismet.Blazor.Index);
        }
        if (GameName == "LifeBoardGame")
        {
            return typeof(LifeBoardGame.Blazor.Index);
        }
        if (GameName == "LifeCardGame")
        {
            return typeof(LifeCardGame.Blazor.Index);
        }
        if (GameName == "LottoDominos")
        {
            return typeof(LottoDominos.Blazor.Index);
        }
        if (GameName == "Mancala")
        {
            return typeof(Mancala.Blazor.Index);
        }
        if (GameName == "MilkRun")
        {
            return typeof(MilkRun.Blazor.Index);
        }
        if (GameName == "Millebournes")
        {
            return typeof(Millebournes.Blazor.Index);
        }
        if (GameName == "MonasteryCardGame")
        {
            return typeof(MonasteryCardGame.Blazor.Index);
        }
        if (GameName == "MonopolyCardGame")
        {
            return typeof(MonopolyCardGame.Blazor.Index);
        }
        if (GameName == "MonopolyDicedGame")
        {
            return typeof(MonopolyDicedGame.Blazor.Index);
        }
        if (GameName == "OldMaid")
        {
            return typeof(OldMaid.Blazor.Index);
        }
        if (GameName == "Opetong")
        {
            return typeof(Opetong.Blazor.Index);
        }
        if (GameName == "PassOutDiceGame")
        {
            return typeof(PassOutDiceGame.Blazor.Index);
        }
        if (GameName == "Payday")
        {
            return typeof(Payday.Blazor.Index);
        }
        if (GameName == "Phase10")
        {
            return typeof(Phase10.Blazor.Index);
        }
        if (GameName == "PickelCardGame")
        {
            return typeof(PickelCardGame.Blazor.Index);
        }
        if (GameName == "Pinochle2Player")
        {
            return typeof(Pinochle2Player.Blazor.Index);
        }
        if (GameName == "Racko")
        {
            return typeof(Racko.Blazor.Index);
        }
        if (GameName == "RageCardGame")
        {
            return typeof(RageCardGame.Blazor.Index);
        }
        if (GameName == "Risk")
        {
            return typeof(Risk.Blazor.Index);
        }
        if (GameName == "RollEm")
        {
            return typeof(RollEm.Blazor.Index);
        }
        if (GameName == "Rook")
        {
            return typeof(Rook.Blazor.Index);
        }
        if (GameName == "RoundsCardGame")
        {
            return typeof(RoundsCardGame.Blazor.Index);
        }
        if (GameName == "Rummy500")
        {
            return typeof(Rummy500.Blazor.Index);
        }
        if (GameName == "RummyDice")
        {
            return typeof(RummyDice.Blazor.Index);
        }
        if (GameName == "Savannah")
        {
            return typeof(Savannah.Blazor.Index);
        }
        if (GameName == "SequenceDice")
        {
            return typeof(SequenceDice.Blazor.Index);
        }
        if (GameName == "ShipCaptainCrew")
        {
            return typeof(ShipCaptainCrew.Blazor.Index);
        }
        if (GameName == "SinisterSix")
        {
            return typeof(SinisterSix.Blazor.Index);
        }
        if (GameName == "SixtySix2Player")
        {
            return typeof(SixtySix2Player.Blazor.Index);
        }
        if (GameName == "Skipbo")
        {
            return typeof(Skipbo.Blazor.Index);
        }
        if (GameName == "SkuckCardGame")
        {
            return typeof(SkuckCardGame.Blazor.Index);
        }
        if (GameName == "SnagCardGame")
        {
            return typeof(SnagCardGame.Blazor.Index);
        }
        if (GameName == "SnakesAndLadders")
        {
            return typeof(SnakesAndLadders.Blazor.Index);
        }
        if (GameName == "Sorry")
        {
            return typeof(Sorry.Blazor.Index);
        }
        if (GameName == "SorryCardGame")
        {
            return typeof(SorryCardGame.Blazor.Index);
        }
        if (GameName == "Spades4Player")
        {
            return typeof(Spades4Player.Blazor.Index);
        }
        if (GameName == "Spades2Player")
        {
            return typeof(Spades2Player.Blazor.Index);
        }
        if (GameName == "TeeItUp")
        {
            return typeof(TeeItUp.Blazor.Index);
        }
        if (GameName == "ThinkTwice")
        {
            return typeof(ThinkTwice.Blazor.Index);
        }
        if (GameName == "ThreeLetterFun")
        {
            return typeof(ThreeLetterFun.Blazor.Index);
        }
        if (GameName == "TicTacToe")
        {
            return typeof(TicTacToe.Blazor.Index);
        }
        if (GameName == "TileRummy")
        {
            return typeof(TileRummy.Blazor.Index);
        }
        if (GameName == "Trouble")
        {
            return typeof(Trouble.Blazor.Index);
        }
        if (GameName == "Uno")
        {
            return typeof(Uno.Blazor.Index);
        }
        if (GameName == "Xactika")
        {
            return typeof(Xactika.Blazor.Index);
        }
        if (GameName == "YaBlewIt")
        {
            return typeof(YaBlewIt.Blazor.Index);
        }
        if (GameName == "YachtRace")
        {
            return typeof(YachtRace.Blazor.Index);
        }
        if (GameName == "Yahtzee")
        {
            return typeof(Yahtzee.Blazor.Index);
        }
        if (GameName == "YahtzeeHandsDown")
        {
            return typeof(YahtzeeHandsDown.Blazor.Index);
        }
        throw new CustomBasicException("Game Not Found");
    }
    protected override IGameBootstrapper ChooseGame()
    {
        if (GameName == "A21DiceGame")
        {
            return new A21DiceGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "A8RoundRummy")
        {
            return new A8RoundRummy.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Aggravation")
        {
            return new Aggravation.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Backgammon")
        {
            return new Backgammon.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Battleship")
        {
            return new Battleship.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "BattleshipLite")
        {
            return new BattleshipLite.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Bingo")
        {
            return new Bingo.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "BladesOfSteel")
        {
            return new BladesOfSteel.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "BowlingDiceGame")
        {
            return new BowlingDiceGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "CaliforniaJack")
        {
            return new CaliforniaJack.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Candyland")
        {
            return new Candyland.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Checkers")
        {
            return new Checkers.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Chess")
        {
            return new Chess.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Chinazo")
        {
            return new Chinazo.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "ChineseCheckers")
        {
            return new ChineseCheckers.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "ClueBoardGame")
        {
            return new ClueBoardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Concentration")
        {
            return new Concentration.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "ConnectFour")
        {
            return new ConnectFour.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "ConnectTheDots")
        {
            return new ConnectTheDots.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Countdown")
        {
            return new Countdown.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "CousinRummy")
        {
            return new CousinRummy.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "CoveredUp")
        {
            return new CoveredUp.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "CrazyEights")
        {
            return new CrazyEights.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Cribbage")
        {
            return new Cribbage.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "DeadDie96")
        {
            return new DeadDie96.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "DiceDominos")
        {
            return new DiceDominos.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "DominosMexicanTrain")
        {
            return new DominosMexicanTrain.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "DominosRegular")
        {
            return new DominosRegular.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "DummyRummy")
        {
            return new DummyRummy.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "DutchBlitz")
        {
            return new DutchBlitz.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "FillOrBust")
        {
            return new FillOrBust.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "FiveCrowns")
        {
            return new FiveCrowns.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Flinch")
        {
            return new Flinch.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Fluxx")
        {
            return new Fluxx.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "FourSuitRummy")
        {
            return new FourSuitRummy.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "GalaxyCardGame")
        {
            return new GalaxyCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "GermanWhist")
        {
            return new GermanWhist.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "GoFish")
        {
            return new GoFish.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "GolfCardGame")
        {
            return new GolfCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Hearts")
        {
            return new Hearts.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "HitTheDeck")
        {
            return new HitTheDeck.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "HorseshoeCardGame")
        {
            return new HorseshoeCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "HuseHearts")
        {
            return new HuseHearts.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "ItalianDominos")
        {
            return new ItalianDominos.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Kismet")
        {
            return new Kismet.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "LifeBoardGame")
        {
            return new LifeBoardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "LifeCardGame")
        {
            return new LifeCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "LottoDominos")
        {
            return new LottoDominos.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Mancala")
        {
            return new Mancala.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "MilkRun")
        {
            return new MilkRun.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Millebournes")
        {
            return new Millebournes.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "MonasteryCardGame")
        {
            return new MonasteryCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "MonopolyCardGame")
        {
            return new MonopolyCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "MonopolyDicedGame")
        {
            return new MonopolyDicedGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "OldMaid")
        {
            return new OldMaid.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Opetong")
        {
            return new Opetong.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "PassOutDiceGame")
        {
            return new PassOutDiceGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Payday")
        {
            return new Payday.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Phase10")
        {
            return new Phase10.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "PickelCardGame")
        {
            return new PickelCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Pinochle2Player")
        {
            return new Pinochle2Player.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Racko")
        {
            return new Racko.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "RageCardGame")
        {
            return new RageCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Risk")
        {
            return new Risk.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "RollEm")
        {
            return new RollEm.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Rook")
        {
            return new Rook.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "RoundsCardGame")
        {
            return new RoundsCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Rummy500")
        {
            return new Rummy500.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "RummyDice")
        {
            return new RummyDice.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Savannah")
        {
            return new Savannah.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "SequenceDice")
        {
            return new SequenceDice.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "ShipCaptainCrew")
        {
            return new ShipCaptainCrew.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "SinisterSix")
        {
            return new SinisterSix.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "SixtySix2Player")
        {
            return new SixtySix2Player.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Skipbo")
        {
            return new Skipbo.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "SkuckCardGame")
        {
            return new SkuckCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "SnagCardGame")
        {
            return new SnagCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "SnakesAndLadders")
        {
            return new SnakesAndLadders.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Sorry")
        {
            return new Sorry.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "SorryCardGame")
        {
            return new SorryCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Spades4Player")
        {
            return new Spades4Player.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Spades2Player")
        {
            return new Spades2Player.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "TeeItUp")
        {
            return new TeeItUp.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "ThinkTwice")
        {
            return new ThinkTwice.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "ThreeLetterFun")
        {
            return new ThreeLetterFun.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "TicTacToe")
        {
            return new TicTacToe.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "TileRummy")
        {
            return new TileRummy.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Trouble")
        {
            return new Trouble.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Uno")
        {
            return new Uno.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Xactika")
        {
            return new Xactika.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "YaBlewIt")
        {
            return new YaBlewIt.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "YachtRace")
        {
            return new YachtRace.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Yahtzee")
        {
            return new Yahtzee.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "YahtzeeHandsDown")
        {
            return new YahtzeeHandsDown.Blazor.Bootstrapper(Starts, Mode);
        }
        throw new CustomBasicException("Game Not Found");
    }
}