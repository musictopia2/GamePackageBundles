namespace AllMultiplayerGames.WebAssembly;
public class BasicViewModel(IStartUp starts) : LoaderViewModel(starts)
{
    public override string Title => "AllMultiplayerGames.WebAssembly";
    protected override void GenerateGameList()
    {
        GameList = [ "21 Dice Game", "8 Round Rummy", "Aggravation", "Backgammon", "Battleship", "Battleship Lite", "Bingo", "Blades Of Steel", "Bowling Dice Game", "California Jack", "Candyland", "Checkers", "Chess", "Chinazo", "Chinese Checkers", "Clue Board Game", "Concentration", "Connect Four", "Connect The Dots", "Countdown", "Cousin Rummy", "Covered Up", "Crazy Eights", "Cribbage", "Dead Die 96", "Dice Dominos", "Dominos (Mexican Train)", "Dominos (Regular)", "Dummy Rummy", "Dutch Blitz", "Fill Or Bust", "Five Crowns", "Flinch", "Fluxx", "Four Suit Rummy", "Galaxy Card Game", "German Whist", "Go Fish", "Golf Card Game", "Hearts", "Hit The Deck", "Horseshoe", "Huse Hearts", "Italian Dominos", "Kismet", "Life Board Game", "Life Card Game", "Lotto Dominos", "Mancala", "Milk Run", "Millebournes", "Monastery Card Game", "Monopoly Card Game", "Monopoly Diced Game", "Old Maid", "Opetong", "Pass Out Dice Game", "Payday", "Phase 10", "Pickel Card Game", "Pinochle (2 Player)", "Racko", "Rage Card Game", "Risk", "Roll Em", "Rook", "Rounds Card Game", "Rummy 500", "Rummy Dice", "Savannah", "Sequence Dice", "Ship Captain Crew", "Sinister Six", "Sixty Six (2 Player)", "SkipBo", "Skuck Card Game", "Snag Card Game", "Snakes And Ladders", "Sorry", "Sorry Card Game", "Spades", "Spades (2 Player)", "Tee It Up", "Think Twice", "Three Letter Fun", "Tic Tac Toe", "Tile Rummy", "Trouble", "Uno", "Xactika", "Ya Blew It", "Yacht Race", "Yahtzee", "Yahtzee Hands Down"];
    }
    protected override Type GetGameType()
    {
        if (GameName == "21 Dice Game")
        {
            return typeof(A21DiceGame.Blazor.Index);
        }
        if (GameName == "8 Round Rummy")
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
        if (GameName == "Battleship Lite")
        {
            return typeof(BattleshipLite.Blazor.Index);
        }
        if (GameName == "Bingo")
        {
            return typeof(Bingo.Blazor.Index);
        }
        if (GameName == "Blades Of Steel")
        {
            return typeof(BladesOfSteel.Blazor.Index);
        }
        if (GameName == "Bowling Dice Game")
        {
            return typeof(BowlingDiceGame.Blazor.Index);
        }
        if (GameName == "California Jack")
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
        if (GameName == "Chinese Checkers")
        {
            return typeof(ChineseCheckers.Blazor.Index);
        }
        if (GameName == "Clue Board Game")
        {
            return typeof(ClueBoardGame.Blazor.Index);
        }
        if (GameName == "Concentration")
        {
            return typeof(Concentration.Blazor.Index);
        }
        if (GameName == "Connect Four")
        {
            return typeof(ConnectFour.Blazor.Index);
        }
        if (GameName == "Connect The Dots")
        {
            return typeof(ConnectTheDots.Blazor.Index);
        }
        if (GameName == "Countdown")
        {
            return typeof(Countdown.Blazor.Index);
        }
        if (GameName == "Cousin Rummy")
        {
            return typeof(CousinRummy.Blazor.Index);
        }
        if (GameName == "Covered Up")
        {
            return typeof(CoveredUp.Blazor.Index);
        }
        if (GameName == "Crazy Eights")
        {
            return typeof(CrazyEights.Blazor.Index);
        }
        if (GameName == "Cribbage")
        {
            return typeof(Cribbage.Blazor.Index);
        }
        if (GameName == "Dead Die 96")
        {
            return typeof(DeadDie96.Blazor.Index);
        }
        if (GameName == "Dice Dominos")
        {
            return typeof(DiceDominos.Blazor.Index);
        }
        if (GameName == "Dominos (Mexican Train)")
        {
            return typeof(DominosMexicanTrain.Blazor.Index);
        }
        if (GameName == "Dominos (Regular)")
        {
            return typeof(DominosRegular.Blazor.Index);
        }
        if (GameName == "Dummy Rummy")
        {
            return typeof(DummyRummy.Blazor.Index);
        }
        if (GameName == "Dutch Blitz")
        {
            return typeof(DutchBlitz.Blazor.Index);
        }
        if (GameName == "Fill Or Bust")
        {
            return typeof(FillOrBust.Blazor.Index);
        }
        if (GameName == "Five Crowns")
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
        if (GameName == "Four Suit Rummy")
        {
            return typeof(FourSuitRummy.Blazor.Index);
        }
        if (GameName == "Galaxy Card Game")
        {
            return typeof(GalaxyCardGame.Blazor.Index);
        }
        if (GameName == "German Whist")
        {
            return typeof(GermanWhist.Blazor.Index);
        }
        if (GameName == "Go Fish")
        {
            return typeof(GoFish.Blazor.Index);
        }
        if (GameName == "Golf Card Game")
        {
            return typeof(GolfCardGame.Blazor.Index);
        }
        if (GameName == "Hearts")
        {
            return typeof(Hearts.Blazor.Index);
        }
        if (GameName == "Hit The Deck")
        {
            return typeof(HitTheDeck.Blazor.Index);
        }
        if (GameName == "Horseshoe")
        {
            return typeof(HorseshoeCardGame.Blazor.Index);
        }
        if (GameName == "Huse Hearts")
        {
            return typeof(HuseHearts.Blazor.Index);
        }
        if (GameName == "Italian Dominos")
        {
            return typeof(ItalianDominos.Blazor.Index);
        }
        if (GameName == "Kismet")
        {
            return typeof(Kismet.Blazor.Index);
        }
        if (GameName == "Life Board Game")
        {
            return typeof(LifeBoardGame.Blazor.Index);
        }
        if (GameName == "Life Card Game")
        {
            return typeof(LifeCardGame.Blazor.Index);
        }
        if (GameName == "Lotto Dominos")
        {
            return typeof(LottoDominos.Blazor.Index);
        }
        if (GameName == "Mancala")
        {
            return typeof(Mancala.Blazor.Index);
        }
        if (GameName == "Milk Run")
        {
            return typeof(MilkRun.Blazor.Index);
        }
        if (GameName == "Millebournes")
        {
            return typeof(Millebournes.Blazor.Index);
        }
        if (GameName == "Monastery Card Game")
        {
            return typeof(MonasteryCardGame.Blazor.Index);
        }
        if (GameName == "Monopoly Card Game")
        {
            return typeof(MonopolyCardGame.Blazor.Index);
        }
        if (GameName == "Monopoly Diced Game")
        {
            return typeof(MonopolyDicedGame.Blazor.Index);
        }
        if (GameName == "Old Maid")
        {
            return typeof(OldMaid.Blazor.Index);
        }
        if (GameName == "Opetong")
        {
            return typeof(Opetong.Blazor.Index);
        }
        if (GameName == "Pass Out Dice Game")
        {
            return typeof(PassOutDiceGame.Blazor.Index);
        }
        if (GameName == "Payday")
        {
            return typeof(Payday.Blazor.Index);
        }
        if (GameName == "Phase 10")
        {
            return typeof(Phase10.Blazor.Index);
        }
        if (GameName == "Pickel Card Game")
        {
            return typeof(PickelCardGame.Blazor.Index);
        }
        if (GameName == "Pinochle (2 Player)")
        {
            return typeof(Pinochle2Player.Blazor.Index);
        }
        if (GameName == "Racko")
        {
            return typeof(Racko.Blazor.Index);
        }
        if (GameName == "Rage Card Game")
        {
            return typeof(RageCardGame.Blazor.Index);
        }
        if (GameName == "Risk")
        {
            return typeof(Risk.Blazor.Index);
        }
        if (GameName == "Roll Em")
        {
            return typeof(RollEm.Blazor.Index);
        }
        if (GameName == "Rook")
        {
            return typeof(Rook.Blazor.Index);
        }
        if (GameName == "Rounds Card Game")
        {
            return typeof(RoundsCardGame.Blazor.Index);
        }
        if (GameName == "Rummy 500")
        {
            return typeof(Rummy500.Blazor.Index);
        }
        if (GameName == "Rummy Dice")
        {
            return typeof(RummyDice.Blazor.Index);
        }
        if (GameName == "Savannah")
        {
            return typeof(Savannah.Blazor.Index);
        }
        if (GameName == "Sequence Dice")
        {
            return typeof(SequenceDice.Blazor.Index);
        }
        if (GameName == "Ship Captain Crew")
        {
            return typeof(ShipCaptainCrew.Blazor.Index);
        }
        if (GameName == "Sinister Six")
        {
            return typeof(SinisterSix.Blazor.Index);
        }
        if (GameName == "Sixty Six (2 Player)")
        {
            return typeof(SixtySix2Player.Blazor.Index);
        }
        if (GameName == "SkipBo")
        {
            return typeof(Skipbo.Blazor.Index);
        }
        if (GameName == "Skuck Card Game")
        {
            return typeof(SkuckCardGame.Blazor.Index);
        }
        if (GameName == "Snag Card Game")
        {
            return typeof(SnagCardGame.Blazor.Index);
        }
        if (GameName == "Snakes And Ladders")
        {
            return typeof(SnakesAndLadders.Blazor.Index);
        }
        if (GameName == "Sorry")
        {
            return typeof(Sorry.Blazor.Index);
        }
        if (GameName == "Sorry Card Game")
        {
            return typeof(SorryCardGame.Blazor.Index);
        }
        if (GameName == "Spades")
        {
            return typeof(Spades4Player.Blazor.Index);
        }
        if (GameName == "Spades (2 Player)")
        {
            return typeof(Spades2Player.Blazor.Index);
        }
        if (GameName == "Tee It Up")
        {
            return typeof(TeeItUp.Blazor.Index);
        }
        if (GameName == "Think Twice")
        {
            return typeof(ThinkTwice.Blazor.Index);
        }
        if (GameName == "Three Letter Fun")
        {
            return typeof(ThreeLetterFun.Blazor.Index);
        }
        if (GameName == "Tic Tac Toe")
        {
            return typeof(TicTacToe.Blazor.Index);
        }
        if (GameName == "Tile Rummy")
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
        if (GameName == "Ya Blew It")
        {
            return typeof(YaBlewIt.Blazor.Index);
        }
        if (GameName == "Yacht Race")
        {
            return typeof(YachtRace.Blazor.Index);
        }
        if (GameName == "Yahtzee")
        {
            return typeof(Yahtzee.Blazor.Index);
        }
        if (GameName == "Yahtzee Hands Down")
        {
            return typeof(YahtzeeHandsDown.Blazor.Index);
        }
        throw new CustomBasicException("Game Not Found");
    }
    protected override IGameBootstrapper ChooseGame()
    {
        if (GameName == "21 Dice Game")
        {
            return new A21DiceGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "8 Round Rummy")
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
        if (GameName == "Battleship Lite")
        {
            return new BattleshipLite.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Bingo")
        {
            return new Bingo.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Blades Of Steel")
        {
            return new BladesOfSteel.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Bowling Dice Game")
        {
            return new BowlingDiceGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "California Jack")
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
        if (GameName == "Chinese Checkers")
        {
            return new ChineseCheckers.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Clue Board Game")
        {
            return new ClueBoardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Concentration")
        {
            return new Concentration.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Connect Four")
        {
            return new ConnectFour.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Connect The Dots")
        {
            return new ConnectTheDots.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Countdown")
        {
            return new Countdown.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Cousin Rummy")
        {
            return new CousinRummy.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Covered Up")
        {
            return new CoveredUp.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Crazy Eights")
        {
            return new CrazyEights.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Cribbage")
        {
            return new Cribbage.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Dead Die 96")
        {
            return new DeadDie96.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Dice Dominos")
        {
            return new DiceDominos.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Dominos (Mexican Train)")
        {
            return new DominosMexicanTrain.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Dominos (Regular)")
        {
            return new DominosRegular.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Dummy Rummy")
        {
            return new DummyRummy.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Dutch Blitz")
        {
            return new DutchBlitz.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Fill Or Bust")
        {
            return new FillOrBust.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Five Crowns")
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
        if (GameName == "Four Suit Rummy")
        {
            return new FourSuitRummy.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Galaxy Card Game")
        {
            return new GalaxyCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "German Whist")
        {
            return new GermanWhist.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Go Fish")
        {
            return new GoFish.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Golf Card Game")
        {
            return new GolfCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Hearts")
        {
            return new Hearts.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Hit The Deck")
        {
            return new HitTheDeck.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Horseshoe")
        {
            return new HorseshoeCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Huse Hearts")
        {
            return new HuseHearts.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Italian Dominos")
        {
            return new ItalianDominos.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Kismet")
        {
            return new Kismet.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Life Board Game")
        {
            return new LifeBoardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Life Card Game")
        {
            return new LifeCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Lotto Dominos")
        {
            return new LottoDominos.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Mancala")
        {
            return new Mancala.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Milk Run")
        {
            return new MilkRun.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Millebournes")
        {
            return new Millebournes.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Monastery Card Game")
        {
            return new MonasteryCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Monopoly Card Game")
        {
            return new MonopolyCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Monopoly Diced Game")
        {
            return new MonopolyDicedGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Old Maid")
        {
            return new OldMaid.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Opetong")
        {
            return new Opetong.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Pass Out Dice Game")
        {
            return new PassOutDiceGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Payday")
        {
            return new Payday.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Phase 10")
        {
            return new Phase10.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Pickel Card Game")
        {
            return new PickelCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Pinochle (2 Player)")
        {
            return new Pinochle2Player.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Racko")
        {
            return new Racko.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Rage Card Game")
        {
            return new RageCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Risk")
        {
            return new Risk.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Roll Em")
        {
            return new RollEm.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Rook")
        {
            return new Rook.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Rounds Card Game")
        {
            return new RoundsCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Rummy 500")
        {
            return new Rummy500.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Rummy Dice")
        {
            return new RummyDice.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Savannah")
        {
            return new Savannah.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Sequence Dice")
        {
            return new SequenceDice.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Ship Captain Crew")
        {
            return new ShipCaptainCrew.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Sinister Six")
        {
            return new SinisterSix.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Sixty Six (2 Player)")
        {
            return new SixtySix2Player.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "SkipBo")
        {
            return new Skipbo.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Skuck Card Game")
        {
            return new SkuckCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Snag Card Game")
        {
            return new SnagCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Snakes And Ladders")
        {
            return new SnakesAndLadders.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Sorry")
        {
            return new Sorry.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Sorry Card Game")
        {
            return new SorryCardGame.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Spades")
        {
            return new Spades4Player.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Spades (2 Player)")
        {
            return new Spades2Player.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Tee It Up")
        {
            return new TeeItUp.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Think Twice")
        {
            return new ThinkTwice.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Three Letter Fun")
        {
            return new ThreeLetterFun.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Tic Tac Toe")
        {
            return new TicTacToe.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Tile Rummy")
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
        if (GameName == "Ya Blew It")
        {
            return new YaBlewIt.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Yacht Race")
        {
            return new YachtRace.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Yahtzee")
        {
            return new Yahtzee.Blazor.Bootstrapper(Starts, Mode);
        }
        if (GameName == "Yahtzee Hands Down")
        {
            return new YahtzeeHandsDown.Blazor.Bootstrapper(Starts, Mode);
        }
        throw new CustomBasicException("Game Not Found");
    }
}