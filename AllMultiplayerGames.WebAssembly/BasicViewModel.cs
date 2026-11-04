namespace AllMultiplayerGames.WebAssembly;
public class BasicViewModel(IStartUp starts) : LoaderViewModel(starts)
{
    public override string Title => "AllMultiplayerGames.WebAssembly";
    protected override void GenerateGameList()
    {
        RegisterGame(A21DiceGame.Core.Data.A21DiceGameDetailClass.GameName, A21DiceGame.Core.Data.A21DiceGameDetailClass.SupportsCompactLayout);
        RegisterGame(A8RoundRummy.Core.Data.A8RoundRummyDetailClass.GameName, A8RoundRummy.Core.Data.A8RoundRummyDetailClass.SupportsCompactLayout);
        RegisterGame(Aggravation.Core.Data.AggravationDetailClass.GameName, Aggravation.Core.Data.AggravationDetailClass.SupportsCompactLayout);
        RegisterGame(Backgammon.Core.Data.BackgammonDetailClass.GameName, Backgammon.Core.Data.BackgammonDetailClass.SupportsCompactLayout);
        RegisterGame(Battleship.Core.Data.BattleshipDetailClass.GameName, Battleship.Core.Data.BattleshipDetailClass.SupportsCompactLayout);
        RegisterGame(BattleshipLite.Core.Data.BattleshipLiteDetailClass.GameName, BattleshipLite.Core.Data.BattleshipLiteDetailClass.SupportsCompactLayout);
        RegisterGame(Bingo.Core.Data.BingoDetailClass.GameName, Bingo.Core.Data.BingoDetailClass.SupportsCompactLayout);
        RegisterGame(BladesOfSteel.Core.Data.BladesOfSteelDetailClass.GameName, BladesOfSteel.Core.Data.BladesOfSteelDetailClass.SupportsCompactLayout);
        RegisterGame(BowlingDiceGame.Core.Data.BowlingDiceGameDetailClass.GameName, BowlingDiceGame.Core.Data.BowlingDiceGameDetailClass.SupportsCompactLayout);
        RegisterGame(CaliforniaJack.Core.Data.CaliforniaJackDetailClass.GameName, CaliforniaJack.Core.Data.CaliforniaJackDetailClass.SupportsCompactLayout);
        RegisterGame(Candyland.Core.Data.CandylandDetailClass.GameName, Candyland.Core.Data.CandylandDetailClass.SupportsCompactLayout);
        RegisterGame(Checkers.Core.Data.CheckersDetailClass.GameName, Checkers.Core.Data.CheckersDetailClass.SupportsCompactLayout);
        RegisterGame(Chess.Core.Data.ChessDetailClass.GameName, Chess.Core.Data.ChessDetailClass.SupportsCompactLayout);
        RegisterGame(Chinazo.Core.Data.ChinazoDetailClass.GameName, Chinazo.Core.Data.ChinazoDetailClass.SupportsCompactLayout);
        RegisterGame(ChineseCheckers.Core.Data.ChineseCheckersDetailClass.GameName, ChineseCheckers.Core.Data.ChineseCheckersDetailClass.SupportsCompactLayout);
        RegisterGame(ClueBoardGame.Core.Data.ClueBoardGameDetailClass.GameName, ClueBoardGame.Core.Data.ClueBoardGameDetailClass.SupportsCompactLayout);
        RegisterGame(ClueCardGame.Core.Data.ClueCardGameDetailClass.GameName, ClueCardGame.Core.Data.ClueCardGameDetailClass.SupportsCompactLayout);
        RegisterGame(Concentration.Core.Data.ConcentrationDetailClass.GameName, Concentration.Core.Data.ConcentrationDetailClass.SupportsCompactLayout);
        RegisterGame(ConnectFour.Core.Data.ConnectFourDetailClass.GameName, ConnectFour.Core.Data.ConnectFourDetailClass.SupportsCompactLayout);
        RegisterGame(ConnectTheDots.Core.Data.ConnectTheDotsDetailClass.GameName, ConnectTheDots.Core.Data.ConnectTheDotsDetailClass.SupportsCompactLayout);
        RegisterGame(Countdown.Core.Data.CountdownDetailClass.GameName, Countdown.Core.Data.CountdownDetailClass.SupportsCompactLayout);
        RegisterGame(CousinRummy.Core.Data.CousinRummyDetailClass.GameName, CousinRummy.Core.Data.CousinRummyDetailClass.SupportsCompactLayout);
        RegisterGame(CoveredUp.Core.Data.CoveredUpDetailClass.GameName, CoveredUp.Core.Data.CoveredUpDetailClass.SupportsCompactLayout);
        RegisterGame(CrazyEights.Core.Data.CrazyEightsDetailClass.GameName, CrazyEights.Core.Data.CrazyEightsDetailClass.SupportsCompactLayout);
        RegisterGame(Cribbage.Core.Data.CribbageDetailClass.GameName, Cribbage.Core.Data.CribbageDetailClass.SupportsCompactLayout);
        RegisterGame(DeadDie96.Core.Data.DeadDie96DetailClass.GameName, DeadDie96.Core.Data.DeadDie96DetailClass.SupportsCompactLayout);
        RegisterGame(DealCardGame.Core.Data.DealCardGameDetailClass.GameName, DealCardGame.Core.Data.DealCardGameDetailClass.SupportsCompactLayout);
        RegisterGame(DiceDominos.Core.Data.DiceDominosDetailClass.GameName, DiceDominos.Core.Data.DiceDominosDetailClass.SupportsCompactLayout);
        RegisterGame(DominosRegular.Core.Data.DominosRegularDetailClass.GameName, DominosRegular.Core.Data.DominosRegularDetailClass.SupportsCompactLayout);
        RegisterGame(DummyRummy.Core.Data.DummyRummyDetailClass.GameName, DummyRummy.Core.Data.DummyRummyDetailClass.SupportsCompactLayout);
        RegisterGame(DutchBlitz.Core.Data.DutchBlitzDetailClass.GameName, DutchBlitz.Core.Data.DutchBlitzDetailClass.SupportsCompactLayout);
        RegisterGame(FillOrBust.Core.Data.FillOrBustDetailClass.GameName, FillOrBust.Core.Data.FillOrBustDetailClass.SupportsCompactLayout);
        RegisterGame(FiveCrowns.Core.Data.FiveCrownsDetailClass.GameName, FiveCrowns.Core.Data.FiveCrownsDetailClass.SupportsCompactLayout);
        RegisterGame(Flinch.Core.Data.FlinchDetailClass.GameName, Flinch.Core.Data.FlinchDetailClass.SupportsCompactLayout);
        RegisterGame(Fluxx.Core.Data.FluxxDetailClass.GameName, Fluxx.Core.Data.FluxxDetailClass.SupportsCompactLayout);
        RegisterGame(FourSuitRummy.Core.Data.FourSuitRummyDetailClass.GameName, FourSuitRummy.Core.Data.FourSuitRummyDetailClass.SupportsCompactLayout);
        RegisterGame(GalaxyCardGame.Core.Data.GalaxyCardGameDetailClass.GameName, GalaxyCardGame.Core.Data.GalaxyCardGameDetailClass.SupportsCompactLayout);
        RegisterGame(GermanWhist.Core.Data.GermanWhistDetailClass.GameName, GermanWhist.Core.Data.GermanWhistDetailClass.SupportsCompactLayout);
        RegisterGame(GoFish.Core.Data.GoFishDetailClass.GameName, GoFish.Core.Data.GoFishDetailClass.SupportsCompactLayout);
        RegisterGame(GolfCardGame.Core.Data.GolfCardGameDetailClass.GameName, GolfCardGame.Core.Data.GolfCardGameDetailClass.SupportsCompactLayout);
        RegisterGame(Hearts.Core.Data.HeartsDetailClass.GameName, Hearts.Core.Data.HeartsDetailClass.SupportsCompactLayout);
        RegisterGame(HitTheDeck.Core.Data.HitTheDeckDetailClass.GameName, HitTheDeck.Core.Data.HitTheDeckDetailClass.SupportsCompactLayout);
        RegisterGame(HorseshoeCardGame.Core.Data.HorseshoeCardGameDetailClass.GameName, HorseshoeCardGame.Core.Data.HorseshoeCardGameDetailClass.SupportsCompactLayout);
        RegisterGame(HuseHearts.Core.Data.HuseHeartsDetailClass.GameName, HuseHearts.Core.Data.HuseHeartsDetailClass.SupportsCompactLayout);
        RegisterGame(ItalianDominos.Core.Data.ItalianDominosDetailClass.GameName, ItalianDominos.Core.Data.ItalianDominosDetailClass.SupportsCompactLayout);
        RegisterGame(Kismet.Core.Data.KismetDetailClass.GameName, Kismet.Core.Data.KismetDetailClass.SupportsCompactLayout);
        RegisterGame(LifeBoardGame.Core.Data.LifeBoardGameDetailClass.GameName, LifeBoardGame.Core.Data.LifeBoardGameDetailClass.SupportsCompactLayout);
        RegisterGame(LifeCardGame.Core.Data.LifeCardGameDetailClass.GameName, LifeCardGame.Core.Data.LifeCardGameDetailClass.SupportsCompactLayout);
        RegisterGame(LottoDominos.Core.Data.LottoDominosDetailClass.GameName, LottoDominos.Core.Data.LottoDominosDetailClass.SupportsCompactLayout);
        RegisterGame(Mancala.Core.Data.MancalaDetailClass.GameName, Mancala.Core.Data.MancalaDetailClass.SupportsCompactLayout);
        RegisterGame(MilkRun.Core.Data.MilkRunDetailClass.GameName, MilkRun.Core.Data.MilkRunDetailClass.SupportsCompactLayout);
        RegisterGame(Millebournes.Core.Data.MillebournesDetailClass.GameName, Millebournes.Core.Data.MillebournesDetailClass.SupportsCompactLayout);
        RegisterGame(MonasteryCardGame.Core.Data.MonasteryCardGameDetailClass.GameName, MonasteryCardGame.Core.Data.MonasteryCardGameDetailClass.SupportsCompactLayout);
        RegisterGame(MonopolyCardGame.Core.Data.MonopolyCardGameDetailClass.GameName, MonopolyCardGame.Core.Data.MonopolyCardGameDetailClass.SupportsCompactLayout);
        RegisterGame(MonopolyDicedGame.Core.Data.MonopolyDicedGameDetailClass.GameName, MonopolyDicedGame.Core.Data.MonopolyDicedGameDetailClass.SupportsCompactLayout);
        RegisterGame(OldMaid.Core.Data.OldMaidDetailClass.GameName, OldMaid.Core.Data.OldMaidDetailClass.SupportsCompactLayout);
        RegisterGame(Opetong.Core.Data.OpetongDetailClass.GameName, Opetong.Core.Data.OpetongDetailClass.SupportsCompactLayout);
        RegisterGame(PassOutDiceGame.Core.Data.PassOutDiceGameDetailClass.GameName, PassOutDiceGame.Core.Data.PassOutDiceGameDetailClass.SupportsCompactLayout);
        RegisterGame(Payday.Core.Data.PaydayDetailClass.GameName, Payday.Core.Data.PaydayDetailClass.SupportsCompactLayout);
        RegisterGame(Phase10.Core.Data.Phase10DetailClass.GameName, Phase10.Core.Data.Phase10DetailClass.SupportsCompactLayout);
        RegisterGame(PickelCardGame.Core.Data.PickelCardGameDetailClass.GameName, PickelCardGame.Core.Data.PickelCardGameDetailClass.SupportsCompactLayout);
        RegisterGame(Pinochle2Player.Core.Data.Pinochle2PlayerDetailClass.GameName, Pinochle2Player.Core.Data.Pinochle2PlayerDetailClass.SupportsCompactLayout);
        RegisterGame(Racko.Core.Data.RackoDetailClass.GameName, Racko.Core.Data.RackoDetailClass.SupportsCompactLayout);
        RegisterGame(RageCardGame.Core.Data.RageCardGameDetailClass.GameName, RageCardGame.Core.Data.RageCardGameDetailClass.SupportsCompactLayout);
        RegisterGame(Risk.Core.Data.RiskDetailClass.GameName, Risk.Core.Data.RiskDetailClass.SupportsCompactLayout);
        RegisterGame(RollEm.Core.Data.RollEmDetailClass.GameName, RollEm.Core.Data.RollEmDetailClass.SupportsCompactLayout);
        RegisterGame(Rook.Core.Data.RookDetailClass.GameName, Rook.Core.Data.RookDetailClass.SupportsCompactLayout);
        RegisterGame(RoundsCardGame.Core.Data.RoundsCardGameDetailClass.GameName, RoundsCardGame.Core.Data.RoundsCardGameDetailClass.SupportsCompactLayout);
        RegisterGame(RummyDice.Core.Data.RummyDiceDetailClass.GameName, RummyDice.Core.Data.RummyDiceDetailClass.SupportsCompactLayout);
        RegisterGame(Rummy500.Core.Data.Rummy500DetailClass.GameName, Rummy500.Core.Data.Rummy500DetailClass.SupportsCompactLayout);
        RegisterGame(Savannah.Core.Data.SavannahDetailClass.GameName, Savannah.Core.Data.SavannahDetailClass.SupportsCompactLayout);
        RegisterGame(SequenceDice.Core.Data.SequenceDiceDetailClass.GameName, SequenceDice.Core.Data.SequenceDiceDetailClass.SupportsCompactLayout);
        RegisterGame(ShipCaptainCrew.Core.Data.ShipCaptainCrewDetailClass.GameName, ShipCaptainCrew.Core.Data.ShipCaptainCrewDetailClass.SupportsCompactLayout);
        RegisterGame(SinisterSix.Core.Data.SinisterSixDetailClass.GameName, SinisterSix.Core.Data.SinisterSixDetailClass.SupportsCompactLayout);
        RegisterGame(SixtySix2Player.Core.Data.SixtySix2PlayerDetailClass.GameName, SixtySix2Player.Core.Data.SixtySix2PlayerDetailClass.SupportsCompactLayout);
        RegisterGame(Skipbo.Core.Data.SkipboDetailClass.GameName, Skipbo.Core.Data.SkipboDetailClass.SupportsCompactLayout);
        RegisterGame(SkuckCardGame.Core.Data.SkuckCardGameDetailClass.GameName, SkuckCardGame.Core.Data.SkuckCardGameDetailClass.SupportsCompactLayout);
        RegisterGame(SnagCardGame.Core.Data.SnagCardGameDetailClass.GameName, SnagCardGame.Core.Data.SnagCardGameDetailClass.SupportsCompactLayout);
        RegisterGame(SnakesAndLadders.Core.Data.SnakesAndLaddersDetailClass.GameName, SnakesAndLadders.Core.Data.SnakesAndLaddersDetailClass.SupportsCompactLayout);
        RegisterGame(Sorry.Core.Data.SorryDetailClass.GameName, Sorry.Core.Data.SorryDetailClass.SupportsCompactLayout);
        RegisterGame(SorryCardGame.Core.Data.SorryCardGameDetailClass.GameName, SorryCardGame.Core.Data.SorryCardGameDetailClass.SupportsCompactLayout);
        RegisterGame(SorryDicedGame.Core.Data.SorryDicedGameDetailClass.GameName, SorryDicedGame.Core.Data.SorryDicedGameDetailClass.SupportsCompactLayout);
        RegisterGame(Spades2Player.Core.Data.Spades2PlayerDetailClass.GameName, Spades2Player.Core.Data.Spades2PlayerDetailClass.SupportsCompactLayout);
        RegisterGame(Spades4Player.Core.Data.Spades4PlayerDetailClass.GameName, Spades4Player.Core.Data.Spades4PlayerDetailClass.SupportsCompactLayout);
        RegisterGame(TeeItUp.Core.Data.TeeItUpDetailClass.GameName, TeeItUp.Core.Data.TeeItUpDetailClass.SupportsCompactLayout);
        RegisterGame(ThinkTwice.Core.Data.ThinkTwiceDetailClass.GameName, ThinkTwice.Core.Data.ThinkTwiceDetailClass.SupportsCompactLayout);
        RegisterGame(ThreeLetterFun.Core.Data.ThreeLetterFunDetailClass.GameName, ThreeLetterFun.Core.Data.ThreeLetterFunDetailClass.SupportsCompactLayout);
        RegisterGame(TicTacToe.Core.Data.TicTacToeDetailClass.GameName, TicTacToe.Core.Data.TicTacToeDetailClass.SupportsCompactLayout);
        RegisterGame(TileRummy.Core.Data.TileRummyDetailClass.GameName, TileRummy.Core.Data.TileRummyDetailClass.SupportsCompactLayout);
        RegisterGame(Trouble.Core.Data.TroubleDetailClass.GameName, Trouble.Core.Data.TroubleDetailClass.SupportsCompactLayout);
        RegisterGame(Uno.Core.Data.UnoDetailClass.GameName, Uno.Core.Data.UnoDetailClass.SupportsCompactLayout);
        RegisterGame(Xactika.Core.Data.XactikaDetailClass.GameName, Xactika.Core.Data.XactikaDetailClass.SupportsCompactLayout);
        RegisterGame(YaBlewIt.Core.Data.YaBlewItDetailClass.GameName, YaBlewIt.Core.Data.YaBlewItDetailClass.SupportsCompactLayout);
        RegisterGame(YachtRace.Core.Data.YachtRaceDetailClass.GameName, YachtRace.Core.Data.YachtRaceDetailClass.SupportsCompactLayout);
        RegisterGame(Yahtzee.Core.Data.YahtzeeDetailClass.GameName, Yahtzee.Core.Data.YahtzeeDetailClass.SupportsCompactLayout);
        RegisterGame(YahtzeeHandsDown.Core.Data.YahtzeeHandsDownDetailClass.GameName, YahtzeeHandsDown.Core.Data.YahtzeeHandsDownDetailClass.SupportsCompactLayout);
    }

    protected override IGameBootstrapper ChooseGame()
    {
        return GameName switch
        {
            A21DiceGame.Core.Data.A21DiceGameDetailClass.GameName =>
                new A21DiceGame.Blazor.Bootstrapper(Starts, Mode, null),

            A8RoundRummy.Core.Data.A8RoundRummyDetailClass.GameName =>
                new A8RoundRummy.Blazor.Bootstrapper(Starts, Mode, null),

            Aggravation.Core.Data.AggravationDetailClass.GameName =>
                new Aggravation.Blazor.Bootstrapper(Starts, Mode, null),

            Backgammon.Core.Data.BackgammonDetailClass.GameName =>
                new Backgammon.Blazor.Bootstrapper(Starts, Mode, null),

            Battleship.Core.Data.BattleshipDetailClass.GameName =>
                new Battleship.Blazor.Bootstrapper(Starts, Mode, null),

            BattleshipLite.Core.Data.BattleshipLiteDetailClass.GameName =>
                new BattleshipLite.Blazor.Bootstrapper(Starts, Mode, null),

            Bingo.Core.Data.BingoDetailClass.GameName =>
                new Bingo.Blazor.Bootstrapper(Starts, Mode, null),

            BladesOfSteel.Core.Data.BladesOfSteelDetailClass.GameName =>
                new BladesOfSteel.Blazor.Bootstrapper(Starts, Mode, null),

            BowlingDiceGame.Core.Data.BowlingDiceGameDetailClass.GameName =>
                new BowlingDiceGame.Blazor.Bootstrapper(Starts, Mode, null),

            CaliforniaJack.Core.Data.CaliforniaJackDetailClass.GameName =>
                new CaliforniaJack.Blazor.Bootstrapper(Starts, Mode, null),

            Candyland.Core.Data.CandylandDetailClass.GameName =>
                new Candyland.Blazor.Bootstrapper(Starts, Mode, null),

            Checkers.Core.Data.CheckersDetailClass.GameName =>
                new Checkers.Blazor.Bootstrapper(Starts, Mode, null),

            Chess.Core.Data.ChessDetailClass.GameName =>
                new Chess.Blazor.Bootstrapper(Starts, Mode, null),

            Chinazo.Core.Data.ChinazoDetailClass.GameName =>
                new Chinazo.Blazor.Bootstrapper(Starts, Mode, null),

            ChineseCheckers.Core.Data.ChineseCheckersDetailClass.GameName =>
                new ChineseCheckers.Blazor.Bootstrapper(Starts, Mode, null),

            ClueBoardGame.Core.Data.ClueBoardGameDetailClass.GameName =>
                new ClueBoardGame.Blazor.Bootstrapper(Starts, Mode, null),

            ClueCardGame.Core.Data.ClueCardGameDetailClass.GameName =>
                new ClueCardGame.Blazor.Bootstrapper(Starts, Mode, null),

            Concentration.Core.Data.ConcentrationDetailClass.GameName =>
                new Concentration.Blazor.Bootstrapper(Starts, Mode, null),

            ConnectFour.Core.Data.ConnectFourDetailClass.GameName =>
                new ConnectFour.Blazor.Bootstrapper(Starts, Mode, null),

            ConnectTheDots.Core.Data.ConnectTheDotsDetailClass.GameName =>
                new ConnectTheDots.Blazor.Bootstrapper(Starts, Mode, null),

            Countdown.Core.Data.CountdownDetailClass.GameName =>
                new Countdown.Blazor.Bootstrapper(Starts, Mode, null),

            CousinRummy.Core.Data.CousinRummyDetailClass.GameName =>
                new CousinRummy.Blazor.Bootstrapper(Starts, Mode, null),

            CoveredUp.Core.Data.CoveredUpDetailClass.GameName =>
                new CoveredUp.Blazor.Bootstrapper(Starts, Mode, null),

            CrazyEights.Core.Data.CrazyEightsDetailClass.GameName =>
                new CrazyEights.Blazor.Bootstrapper(Starts, Mode, null),

            Cribbage.Core.Data.CribbageDetailClass.GameName =>
                new Cribbage.Blazor.Bootstrapper(Starts, Mode, null),

            DeadDie96.Core.Data.DeadDie96DetailClass.GameName =>
                new DeadDie96.Blazor.Bootstrapper(Starts, Mode, null),

            DealCardGame.Core.Data.DealCardGameDetailClass.GameName =>
                new DealCardGame.Blazor.Bootstrapper(Starts, Mode, null),

            DiceDominos.Core.Data.DiceDominosDetailClass.GameName =>
                new DiceDominos.Blazor.Bootstrapper(Starts, Mode, null),

            DominosRegular.Core.Data.DominosRegularDetailClass.GameName =>
                new DominosRegular.Blazor.Bootstrapper(Starts, Mode, null),

            DummyRummy.Core.Data.DummyRummyDetailClass.GameName =>
                new DummyRummy.Blazor.Bootstrapper(Starts, Mode, null),

            DutchBlitz.Core.Data.DutchBlitzDetailClass.GameName =>
                new DutchBlitz.Blazor.Bootstrapper(Starts, Mode, null),

            FillOrBust.Core.Data.FillOrBustDetailClass.GameName =>
                new FillOrBust.Blazor.Bootstrapper(Starts, Mode, null),

            FiveCrowns.Core.Data.FiveCrownsDetailClass.GameName =>
                new FiveCrowns.Blazor.Bootstrapper(Starts, Mode, null),

            Flinch.Core.Data.FlinchDetailClass.GameName =>
                new Flinch.Blazor.Bootstrapper(Starts, Mode, null),

            Fluxx.Core.Data.FluxxDetailClass.GameName =>
                new Fluxx.Blazor.Bootstrapper(Starts, Mode, null),

            FourSuitRummy.Core.Data.FourSuitRummyDetailClass.GameName =>
                new FourSuitRummy.Blazor.Bootstrapper(Starts, Mode, null),

            GalaxyCardGame.Core.Data.GalaxyCardGameDetailClass.GameName =>
                new GalaxyCardGame.Blazor.Bootstrapper(Starts, Mode, null),

            GermanWhist.Core.Data.GermanWhistDetailClass.GameName =>
                new GermanWhist.Blazor.Bootstrapper(Starts, Mode, null),

            GoFish.Core.Data.GoFishDetailClass.GameName =>
                new GoFish.Blazor.Bootstrapper(Starts, Mode, null),

            GolfCardGame.Core.Data.GolfCardGameDetailClass.GameName =>
                new GolfCardGame.Blazor.Bootstrapper(Starts, Mode, null),

            Hearts.Core.Data.HeartsDetailClass.GameName =>
                new Hearts.Blazor.Bootstrapper(Starts, Mode, null),

            HitTheDeck.Core.Data.HitTheDeckDetailClass.GameName =>
                new HitTheDeck.Blazor.Bootstrapper(Starts, Mode, null),

            HorseshoeCardGame.Core.Data.HorseshoeCardGameDetailClass.GameName =>
                new HorseshoeCardGame.Blazor.Bootstrapper(Starts, Mode, null),

            HuseHearts.Core.Data.HuseHeartsDetailClass.GameName =>
                new HuseHearts.Blazor.Bootstrapper(Starts, Mode, null),

            ItalianDominos.Core.Data.ItalianDominosDetailClass.GameName =>
                new ItalianDominos.Blazor.Bootstrapper(Starts, Mode, null),

            Kismet.Core.Data.KismetDetailClass.GameName =>
                new Kismet.Blazor.Bootstrapper(Starts, Mode, null),

            LifeBoardGame.Core.Data.LifeBoardGameDetailClass.GameName =>
                new LifeBoardGame.Blazor.Bootstrapper(Starts, Mode, null),

            LifeCardGame.Core.Data.LifeCardGameDetailClass.GameName =>
                new LifeCardGame.Blazor.Bootstrapper(Starts, Mode, null),

            LottoDominos.Core.Data.LottoDominosDetailClass.GameName =>
                new LottoDominos.Blazor.Bootstrapper(Starts, Mode, null),

            Mancala.Core.Data.MancalaDetailClass.GameName =>
                new Mancala.Blazor.Bootstrapper(Starts, Mode, null),

            MilkRun.Core.Data.MilkRunDetailClass.GameName =>
                new MilkRun.Blazor.Bootstrapper(Starts, Mode, null),

            Millebournes.Core.Data.MillebournesDetailClass.GameName =>
                new Millebournes.Blazor.Bootstrapper(Starts, Mode, null),

            MonasteryCardGame.Core.Data.MonasteryCardGameDetailClass.GameName =>
                new MonasteryCardGame.Blazor.Bootstrapper(Starts, Mode, null),

            MonopolyCardGame.Core.Data.MonopolyCardGameDetailClass.GameName =>
                new MonopolyCardGame.Blazor.Bootstrapper(Starts, Mode, null),

            MonopolyDicedGame.Core.Data.MonopolyDicedGameDetailClass.GameName =>
                new MonopolyDicedGame.Blazor.Bootstrapper(Starts, Mode, null),

            OldMaid.Core.Data.OldMaidDetailClass.GameName =>
                new OldMaid.Blazor.Bootstrapper(Starts, Mode, null),

            Opetong.Core.Data.OpetongDetailClass.GameName =>
                new Opetong.Blazor.Bootstrapper(Starts, Mode, null),

            PassOutDiceGame.Core.Data.PassOutDiceGameDetailClass.GameName =>
                new PassOutDiceGame.Blazor.Bootstrapper(Starts, Mode, null),

            Payday.Core.Data.PaydayDetailClass.GameName =>
                new Payday.Blazor.Bootstrapper(Starts, Mode, null),

            Phase10.Core.Data.Phase10DetailClass.GameName =>
                new Phase10.Blazor.Bootstrapper(Starts, Mode, null),

            PickelCardGame.Core.Data.PickelCardGameDetailClass.GameName =>
                new PickelCardGame.Blazor.Bootstrapper(Starts, Mode, null),

            Pinochle2Player.Core.Data.Pinochle2PlayerDetailClass.GameName =>
                new Pinochle2Player.Blazor.Bootstrapper(Starts, Mode, null),

            Racko.Core.Data.RackoDetailClass.GameName =>
                new Racko.Blazor.Bootstrapper(Starts, Mode, null),

            RageCardGame.Core.Data.RageCardGameDetailClass.GameName =>
                new RageCardGame.Blazor.Bootstrapper(Starts, Mode, null),

            Risk.Core.Data.RiskDetailClass.GameName =>
                new Risk.Blazor.Bootstrapper(Starts, Mode, null),

            RollEm.Core.Data.RollEmDetailClass.GameName =>
                new RollEm.Blazor.Bootstrapper(Starts, Mode, null),

            Rook.Core.Data.RookDetailClass.GameName =>
                new Rook.Blazor.Bootstrapper(Starts, Mode, null),

            RoundsCardGame.Core.Data.RoundsCardGameDetailClass.GameName =>
                new RoundsCardGame.Blazor.Bootstrapper(Starts, Mode, null),

            RummyDice.Core.Data.RummyDiceDetailClass.GameName =>
                new RummyDice.Blazor.Bootstrapper(Starts, Mode, null),

            Rummy500.Core.Data.Rummy500DetailClass.GameName =>
                new Rummy500.Blazor.Bootstrapper(Starts, Mode, null),

            Savannah.Core.Data.SavannahDetailClass.GameName =>
                new Savannah.Blazor.Bootstrapper(Starts, Mode, null),

            SequenceDice.Core.Data.SequenceDiceDetailClass.GameName =>
                new SequenceDice.Blazor.Bootstrapper(Starts, Mode, null),

            ShipCaptainCrew.Core.Data.ShipCaptainCrewDetailClass.GameName =>
                new ShipCaptainCrew.Blazor.Bootstrapper(Starts, Mode, null),

            SinisterSix.Core.Data.SinisterSixDetailClass.GameName =>
                new SinisterSix.Blazor.Bootstrapper(Starts, Mode, null),

            SixtySix2Player.Core.Data.SixtySix2PlayerDetailClass.GameName =>
                new SixtySix2Player.Blazor.Bootstrapper(Starts, Mode, null),

            Skipbo.Core.Data.SkipboDetailClass.GameName =>
                new Skipbo.Blazor.Bootstrapper(Starts, Mode, null),

            SkuckCardGame.Core.Data.SkuckCardGameDetailClass.GameName =>
                new SkuckCardGame.Blazor.Bootstrapper(Starts, Mode, null),

            SnagCardGame.Core.Data.SnagCardGameDetailClass.GameName =>
                new SnagCardGame.Blazor.Bootstrapper(Starts, Mode, null),

            SnakesAndLadders.Core.Data.SnakesAndLaddersDetailClass.GameName =>
                new SnakesAndLadders.Blazor.Bootstrapper(Starts, Mode, null),

            Sorry.Core.Data.SorryDetailClass.GameName =>
                new Sorry.Blazor.Bootstrapper(Starts, Mode, null),

            SorryCardGame.Core.Data.SorryCardGameDetailClass.GameName =>
                new SorryCardGame.Blazor.Bootstrapper(Starts, Mode, null),

            SorryDicedGame.Core.Data.SorryDicedGameDetailClass.GameName =>
                new SorryDicedGame.Blazor.Bootstrapper(Starts, Mode, null),

            Spades2Player.Core.Data.Spades2PlayerDetailClass.GameName =>
                new Spades2Player.Blazor.Bootstrapper(Starts, Mode, null),

            Spades4Player.Core.Data.Spades4PlayerDetailClass.GameName =>
                new Spades4Player.Blazor.Bootstrapper(Starts, Mode, null),

            TeeItUp.Core.Data.TeeItUpDetailClass.GameName =>
                new TeeItUp.Blazor.Bootstrapper(Starts, Mode, null),

            ThinkTwice.Core.Data.ThinkTwiceDetailClass.GameName =>
                new ThinkTwice.Blazor.Bootstrapper(Starts, Mode, null),

            ThreeLetterFun.Core.Data.ThreeLetterFunDetailClass.GameName =>
                new ThreeLetterFun.Blazor.Bootstrapper(Starts, Mode, null),

            TicTacToe.Core.Data.TicTacToeDetailClass.GameName =>
                new TicTacToe.Blazor.Bootstrapper(Starts, Mode, null),

            TileRummy.Core.Data.TileRummyDetailClass.GameName =>
                new TileRummy.Blazor.Bootstrapper(Starts, Mode, null),

            Trouble.Core.Data.TroubleDetailClass.GameName =>
                new Trouble.Blazor.Bootstrapper(Starts, Mode, null),

            Uno.Core.Data.UnoDetailClass.GameName =>
                new Uno.Blazor.Bootstrapper(Starts, Mode, null),

            Xactika.Core.Data.XactikaDetailClass.GameName =>
                new Xactika.Blazor.Bootstrapper(Starts, Mode, null),

            YaBlewIt.Core.Data.YaBlewItDetailClass.GameName =>
                new YaBlewIt.Blazor.Bootstrapper(Starts, Mode, null),

            YachtRace.Core.Data.YachtRaceDetailClass.GameName =>
                new YachtRace.Blazor.Bootstrapper(Starts, Mode, null),

            Yahtzee.Core.Data.YahtzeeDetailClass.GameName =>
                new Yahtzee.Blazor.Bootstrapper(Starts, Mode, null),

            YahtzeeHandsDown.Core.Data.YahtzeeHandsDownDetailClass.GameName =>
                new YahtzeeHandsDown.Blazor.Bootstrapper(Starts, Mode, null),

            _ => throw new CustomBasicException(
                $"Game not found: {GameName}")
        };
    }

    protected override Type GetGameType()
    {
        return GameName switch
        {
            A21DiceGame.Core.Data.A21DiceGameDetailClass.GameName =>
                typeof(A21DiceGame.Blazor.Index),

            A8RoundRummy.Core.Data.A8RoundRummyDetailClass.GameName =>
                typeof(A8RoundRummy.Blazor.Index),

            Aggravation.Core.Data.AggravationDetailClass.GameName =>
                typeof(Aggravation.Blazor.Index),

            Backgammon.Core.Data.BackgammonDetailClass.GameName =>
                typeof(Backgammon.Blazor.Index),

            Battleship.Core.Data.BattleshipDetailClass.GameName =>
                typeof(Battleship.Blazor.Index),

            BattleshipLite.Core.Data.BattleshipLiteDetailClass.GameName =>
                typeof(BattleshipLite.Blazor.Index),

            Bingo.Core.Data.BingoDetailClass.GameName =>
                typeof(Bingo.Blazor.Index),

            BladesOfSteel.Core.Data.BladesOfSteelDetailClass.GameName =>
                typeof(BladesOfSteel.Blazor.Index),

            BowlingDiceGame.Core.Data.BowlingDiceGameDetailClass.GameName =>
                typeof(BowlingDiceGame.Blazor.Index),

            CaliforniaJack.Core.Data.CaliforniaJackDetailClass.GameName =>
                typeof(CaliforniaJack.Blazor.Index),

            Candyland.Core.Data.CandylandDetailClass.GameName =>
                typeof(Candyland.Blazor.Index),

            Checkers.Core.Data.CheckersDetailClass.GameName =>
                typeof(Checkers.Blazor.Index),

            Chess.Core.Data.ChessDetailClass.GameName =>
                typeof(Chess.Blazor.Index),

            Chinazo.Core.Data.ChinazoDetailClass.GameName =>
                typeof(Chinazo.Blazor.Index),

            ChineseCheckers.Core.Data.ChineseCheckersDetailClass.GameName =>
                typeof(ChineseCheckers.Blazor.Index),

            ClueBoardGame.Core.Data.ClueBoardGameDetailClass.GameName =>
                typeof(ClueBoardGame.Blazor.Index),

            ClueCardGame.Core.Data.ClueCardGameDetailClass.GameName =>
                typeof(ClueCardGame.Blazor.Index),

            Concentration.Core.Data.ConcentrationDetailClass.GameName =>
                typeof(Concentration.Blazor.Index),

            ConnectFour.Core.Data.ConnectFourDetailClass.GameName =>
                typeof(ConnectFour.Blazor.Index),

            ConnectTheDots.Core.Data.ConnectTheDotsDetailClass.GameName =>
                typeof(ConnectTheDots.Blazor.Index),

            Countdown.Core.Data.CountdownDetailClass.GameName =>
                typeof(Countdown.Blazor.Index),

            CousinRummy.Core.Data.CousinRummyDetailClass.GameName =>
                typeof(CousinRummy.Blazor.Index),

            CoveredUp.Core.Data.CoveredUpDetailClass.GameName =>
                typeof(CoveredUp.Blazor.Index),

            CrazyEights.Core.Data.CrazyEightsDetailClass.GameName =>
                typeof(CrazyEights.Blazor.Index),

            Cribbage.Core.Data.CribbageDetailClass.GameName =>
                typeof(Cribbage.Blazor.Index),

            DeadDie96.Core.Data.DeadDie96DetailClass.GameName =>
                typeof(DeadDie96.Blazor.Index),

            DealCardGame.Core.Data.DealCardGameDetailClass.GameName =>
                typeof(DealCardGame.Blazor.Index),

            DiceDominos.Core.Data.DiceDominosDetailClass.GameName =>
                typeof(DiceDominos.Blazor.Index),

            DominosRegular.Core.Data.DominosRegularDetailClass.GameName =>
                typeof(DominosRegular.Blazor.Index),

            DummyRummy.Core.Data.DummyRummyDetailClass.GameName =>
                typeof(DummyRummy.Blazor.Index),

            DutchBlitz.Core.Data.DutchBlitzDetailClass.GameName =>
                typeof(DutchBlitz.Blazor.Index),

            FillOrBust.Core.Data.FillOrBustDetailClass.GameName =>
                typeof(FillOrBust.Blazor.Index),

            FiveCrowns.Core.Data.FiveCrownsDetailClass.GameName =>
                typeof(FiveCrowns.Blazor.Index),

            Flinch.Core.Data.FlinchDetailClass.GameName =>
                typeof(Flinch.Blazor.Index),

            Fluxx.Core.Data.FluxxDetailClass.GameName =>
                typeof(Fluxx.Blazor.Index),

            FourSuitRummy.Core.Data.FourSuitRummyDetailClass.GameName =>
                typeof(FourSuitRummy.Blazor.Index),

            GalaxyCardGame.Core.Data.GalaxyCardGameDetailClass.GameName =>
                typeof(GalaxyCardGame.Blazor.Index),

            GermanWhist.Core.Data.GermanWhistDetailClass.GameName =>
                typeof(GermanWhist.Blazor.Index),

            GoFish.Core.Data.GoFishDetailClass.GameName =>
                typeof(GoFish.Blazor.Index),

            GolfCardGame.Core.Data.GolfCardGameDetailClass.GameName =>
                typeof(GolfCardGame.Blazor.Index),

            Hearts.Core.Data.HeartsDetailClass.GameName =>
                typeof(Hearts.Blazor.Index),

            HitTheDeck.Core.Data.HitTheDeckDetailClass.GameName =>
                typeof(HitTheDeck.Blazor.Index),

            HorseshoeCardGame.Core.Data.HorseshoeCardGameDetailClass.GameName =>
                typeof(HorseshoeCardGame.Blazor.Index),

            HuseHearts.Core.Data.HuseHeartsDetailClass.GameName =>
                typeof(HuseHearts.Blazor.Index),

            ItalianDominos.Core.Data.ItalianDominosDetailClass.GameName =>
                typeof(ItalianDominos.Blazor.Index),

            Kismet.Core.Data.KismetDetailClass.GameName =>
                typeof(Kismet.Blazor.Index),

            LifeBoardGame.Core.Data.LifeBoardGameDetailClass.GameName =>
                typeof(LifeBoardGame.Blazor.Index),

            LifeCardGame.Core.Data.LifeCardGameDetailClass.GameName =>
                typeof(LifeCardGame.Blazor.Index),

            LottoDominos.Core.Data.LottoDominosDetailClass.GameName =>
                typeof(LottoDominos.Blazor.Index),

            Mancala.Core.Data.MancalaDetailClass.GameName =>
                typeof(Mancala.Blazor.Index),

            MilkRun.Core.Data.MilkRunDetailClass.GameName =>
                typeof(MilkRun.Blazor.Index),

            Millebournes.Core.Data.MillebournesDetailClass.GameName =>
                typeof(Millebournes.Blazor.Index),

            MonasteryCardGame.Core.Data.MonasteryCardGameDetailClass.GameName =>
                typeof(MonasteryCardGame.Blazor.Index),

            MonopolyCardGame.Core.Data.MonopolyCardGameDetailClass.GameName =>
                typeof(MonopolyCardGame.Blazor.Index),

            MonopolyDicedGame.Core.Data.MonopolyDicedGameDetailClass.GameName =>
                typeof(MonopolyDicedGame.Blazor.Index),

            OldMaid.Core.Data.OldMaidDetailClass.GameName =>
                typeof(OldMaid.Blazor.Index),

            Opetong.Core.Data.OpetongDetailClass.GameName =>
                typeof(Opetong.Blazor.Index),

            PassOutDiceGame.Core.Data.PassOutDiceGameDetailClass.GameName =>
                typeof(PassOutDiceGame.Blazor.Index),

            Payday.Core.Data.PaydayDetailClass.GameName =>
                typeof(Payday.Blazor.Index),

            Phase10.Core.Data.Phase10DetailClass.GameName =>
                typeof(Phase10.Blazor.Index),

            PickelCardGame.Core.Data.PickelCardGameDetailClass.GameName =>
                typeof(PickelCardGame.Blazor.Index),

            Pinochle2Player.Core.Data.Pinochle2PlayerDetailClass.GameName =>
                typeof(Pinochle2Player.Blazor.Index),

            Racko.Core.Data.RackoDetailClass.GameName =>
                typeof(Racko.Blazor.Index),

            RageCardGame.Core.Data.RageCardGameDetailClass.GameName =>
                typeof(RageCardGame.Blazor.Index),

            Risk.Core.Data.RiskDetailClass.GameName =>
                typeof(Risk.Blazor.Index),

            RollEm.Core.Data.RollEmDetailClass.GameName =>
                typeof(RollEm.Blazor.Index),

            Rook.Core.Data.RookDetailClass.GameName =>
                typeof(Rook.Blazor.Index),

            RoundsCardGame.Core.Data.RoundsCardGameDetailClass.GameName =>
                typeof(RoundsCardGame.Blazor.Index),

            RummyDice.Core.Data.RummyDiceDetailClass.GameName =>
                typeof(RummyDice.Blazor.Index),

            Rummy500.Core.Data.Rummy500DetailClass.GameName =>
                typeof(Rummy500.Blazor.Index),

            Savannah.Core.Data.SavannahDetailClass.GameName =>
                typeof(Savannah.Blazor.Index),

            SequenceDice.Core.Data.SequenceDiceDetailClass.GameName =>
                typeof(SequenceDice.Blazor.Index),

            ShipCaptainCrew.Core.Data.ShipCaptainCrewDetailClass.GameName =>
                typeof(ShipCaptainCrew.Blazor.Index),

            SinisterSix.Core.Data.SinisterSixDetailClass.GameName =>
                typeof(SinisterSix.Blazor.Index),

            SixtySix2Player.Core.Data.SixtySix2PlayerDetailClass.GameName =>
                typeof(SixtySix2Player.Blazor.Index),

            Skipbo.Core.Data.SkipboDetailClass.GameName =>
                typeof(Skipbo.Blazor.Index),

            SkuckCardGame.Core.Data.SkuckCardGameDetailClass.GameName =>
                typeof(SkuckCardGame.Blazor.Index),

            SnagCardGame.Core.Data.SnagCardGameDetailClass.GameName =>
                typeof(SnagCardGame.Blazor.Index),

            SnakesAndLadders.Core.Data.SnakesAndLaddersDetailClass.GameName =>
                typeof(SnakesAndLadders.Blazor.Index),

            Sorry.Core.Data.SorryDetailClass.GameName =>
                typeof(Sorry.Blazor.Index),

            SorryCardGame.Core.Data.SorryCardGameDetailClass.GameName =>
                typeof(SorryCardGame.Blazor.Index),

            SorryDicedGame.Core.Data.SorryDicedGameDetailClass.GameName =>
                typeof(SorryDicedGame.Blazor.Index),

            Spades2Player.Core.Data.Spades2PlayerDetailClass.GameName =>
                typeof(Spades2Player.Blazor.Index),

            Spades4Player.Core.Data.Spades4PlayerDetailClass.GameName =>
                typeof(Spades4Player.Blazor.Index),

            TeeItUp.Core.Data.TeeItUpDetailClass.GameName =>
                typeof(TeeItUp.Blazor.Index),

            ThinkTwice.Core.Data.ThinkTwiceDetailClass.GameName =>
                typeof(ThinkTwice.Blazor.Index),

            ThreeLetterFun.Core.Data.ThreeLetterFunDetailClass.GameName =>
                typeof(ThreeLetterFun.Blazor.Index),

            TicTacToe.Core.Data.TicTacToeDetailClass.GameName =>
                typeof(TicTacToe.Blazor.Index),

            TileRummy.Core.Data.TileRummyDetailClass.GameName =>
                typeof(TileRummy.Blazor.Index),

            Trouble.Core.Data.TroubleDetailClass.GameName =>
                typeof(Trouble.Blazor.Index),

            Uno.Core.Data.UnoDetailClass.GameName =>
                typeof(Uno.Blazor.Index),

            Xactika.Core.Data.XactikaDetailClass.GameName =>
                typeof(Xactika.Blazor.Index),

            YaBlewIt.Core.Data.YaBlewItDetailClass.GameName =>
                typeof(YaBlewIt.Blazor.Index),

            YachtRace.Core.Data.YachtRaceDetailClass.GameName =>
                typeof(YachtRace.Blazor.Index),

            Yahtzee.Core.Data.YahtzeeDetailClass.GameName =>
                typeof(Yahtzee.Blazor.Index),

            YahtzeeHandsDown.Core.Data.YahtzeeHandsDownDetailClass.GameName =>
                typeof(YahtzeeHandsDown.Blazor.Index),

            _ => throw new CustomBasicException(
                $"Game not found: {GameName}")
        };
    }
}