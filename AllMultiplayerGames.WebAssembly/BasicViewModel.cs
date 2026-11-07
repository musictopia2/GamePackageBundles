namespace AllMultiplayerGames.WebAssembly;
public class BasicViewModel(IStartUp starts) : LoaderViewModel(starts)
{
    public override string Title => "AllMultiplayerGames.WebAssembly";
    protected override void GenerateGameList()
    {
        RegisterGame(new GameRegistration
        {
            GameName = A21DiceGame.Core.Data.A21DiceGameDetailClass.GameName,
            SupportsCompactLayout = A21DiceGame.Core.Data.A21DiceGameDetailClass.SupportsCompactLayout,
            MinPlayers = A21DiceGame.Core.Data.A21DiceGameDetailClass.MinPlayers,
            MaxPlayers = A21DiceGame.Core.Data.A21DiceGameDetailClass.MaxPlayers,
            NoPlayers = A21DiceGame.Core.Data.A21DiceGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = A21DiceGame.Core.Data.A21DiceGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = A21DiceGame.Core.Data.A21DiceGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = A8RoundRummy.Core.Data.A8RoundRummyDetailClass.GameName,
            SupportsCompactLayout = A8RoundRummy.Core.Data.A8RoundRummyDetailClass.SupportsCompactLayout,
            MinPlayers = A8RoundRummy.Core.Data.A8RoundRummyDetailClass.MinPlayers,
            MaxPlayers = A8RoundRummy.Core.Data.A8RoundRummyDetailClass.MaxPlayers,
            NoPlayers = A8RoundRummy.Core.Data.A8RoundRummyDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = A8RoundRummy.Core.Data.A8RoundRummyDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = A8RoundRummy.Core.Data.A8RoundRummyDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Aggravation.Core.Data.AggravationDetailClass.GameName,
            SupportsCompactLayout = Aggravation.Core.Data.AggravationDetailClass.SupportsCompactLayout,
            MinPlayers = Aggravation.Core.Data.AggravationDetailClass.MinPlayers,
            MaxPlayers = Aggravation.Core.Data.AggravationDetailClass.MaxPlayers,
            NoPlayers = Aggravation.Core.Data.AggravationDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Aggravation.Core.Data.AggravationDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Aggravation.Core.Data.AggravationDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Backgammon.Core.Data.BackgammonDetailClass.GameName,
            SupportsCompactLayout = Backgammon.Core.Data.BackgammonDetailClass.SupportsCompactLayout,
            MinPlayers = Backgammon.Core.Data.BackgammonDetailClass.MinPlayers,
            MaxPlayers = Backgammon.Core.Data.BackgammonDetailClass.MaxPlayers,
            NoPlayers = Backgammon.Core.Data.BackgammonDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Backgammon.Core.Data.BackgammonDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Backgammon.Core.Data.BackgammonDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Battleship.Core.Data.BattleshipDetailClass.GameName,
            SupportsCompactLayout = Battleship.Core.Data.BattleshipDetailClass.SupportsCompactLayout,
            MinPlayers = Battleship.Core.Data.BattleshipDetailClass.MinPlayers,
            MaxPlayers = Battleship.Core.Data.BattleshipDetailClass.MaxPlayers,
            NoPlayers = Battleship.Core.Data.BattleshipDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Battleship.Core.Data.BattleshipDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Battleship.Core.Data.BattleshipDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = BattleshipLite.Core.Data.BattleshipLiteDetailClass.GameName,
            SupportsCompactLayout = BattleshipLite.Core.Data.BattleshipLiteDetailClass.SupportsCompactLayout,
            MinPlayers = BattleshipLite.Core.Data.BattleshipLiteDetailClass.MinPlayers,
            MaxPlayers = BattleshipLite.Core.Data.BattleshipLiteDetailClass.MaxPlayers,
            NoPlayers = BattleshipLite.Core.Data.BattleshipLiteDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = BattleshipLite.Core.Data.BattleshipLiteDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = BattleshipLite.Core.Data.BattleshipLiteDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Bingo.Core.Data.BingoDetailClass.GameName,
            SupportsCompactLayout = Bingo.Core.Data.BingoDetailClass.SupportsCompactLayout,
            MinPlayers = Bingo.Core.Data.BingoDetailClass.MinPlayers,
            MaxPlayers = Bingo.Core.Data.BingoDetailClass.MaxPlayers,
            NoPlayers = Bingo.Core.Data.BingoDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Bingo.Core.Data.BingoDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Bingo.Core.Data.BingoDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = BladesOfSteel.Core.Data.BladesOfSteelDetailClass.GameName,
            SupportsCompactLayout = BladesOfSteel.Core.Data.BladesOfSteelDetailClass.SupportsCompactLayout,
            MinPlayers = BladesOfSteel.Core.Data.BladesOfSteelDetailClass.MinPlayers,
            MaxPlayers = BladesOfSteel.Core.Data.BladesOfSteelDetailClass.MaxPlayers,
            NoPlayers = BladesOfSteel.Core.Data.BladesOfSteelDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = BladesOfSteel.Core.Data.BladesOfSteelDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = BladesOfSteel.Core.Data.BladesOfSteelDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = BowlingDiceGame.Core.Data.BowlingDiceGameDetailClass.GameName,
            SupportsCompactLayout = BowlingDiceGame.Core.Data.BowlingDiceGameDetailClass.SupportsCompactLayout,
            MinPlayers = BowlingDiceGame.Core.Data.BowlingDiceGameDetailClass.MinPlayers,
            MaxPlayers = BowlingDiceGame.Core.Data.BowlingDiceGameDetailClass.MaxPlayers,
            NoPlayers = BowlingDiceGame.Core.Data.BowlingDiceGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = BowlingDiceGame.Core.Data.BowlingDiceGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = BowlingDiceGame.Core.Data.BowlingDiceGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = CaliforniaJack.Core.Data.CaliforniaJackDetailClass.GameName,
            SupportsCompactLayout = CaliforniaJack.Core.Data.CaliforniaJackDetailClass.SupportsCompactLayout,
            MinPlayers = CaliforniaJack.Core.Data.CaliforniaJackDetailClass.MinPlayers,
            MaxPlayers = CaliforniaJack.Core.Data.CaliforniaJackDetailClass.MaxPlayers,
            NoPlayers = CaliforniaJack.Core.Data.CaliforniaJackDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = CaliforniaJack.Core.Data.CaliforniaJackDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = CaliforniaJack.Core.Data.CaliforniaJackDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Candyland.Core.Data.CandylandDetailClass.GameName,
            SupportsCompactLayout = Candyland.Core.Data.CandylandDetailClass.SupportsCompactLayout,
            MinPlayers = Candyland.Core.Data.CandylandDetailClass.MinPlayers,
            MaxPlayers = Candyland.Core.Data.CandylandDetailClass.MaxPlayers,
            NoPlayers = Candyland.Core.Data.CandylandDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Candyland.Core.Data.CandylandDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Candyland.Core.Data.CandylandDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Checkers.Core.Data.CheckersDetailClass.GameName,
            SupportsCompactLayout = Checkers.Core.Data.CheckersDetailClass.SupportsCompactLayout,
            MinPlayers = Checkers.Core.Data.CheckersDetailClass.MinPlayers,
            MaxPlayers = Checkers.Core.Data.CheckersDetailClass.MaxPlayers,
            NoPlayers = Checkers.Core.Data.CheckersDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Checkers.Core.Data.CheckersDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Checkers.Core.Data.CheckersDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Chess.Core.Data.ChessDetailClass.GameName,
            SupportsCompactLayout = Chess.Core.Data.ChessDetailClass.SupportsCompactLayout,
            MinPlayers = Chess.Core.Data.ChessDetailClass.MinPlayers,
            MaxPlayers = Chess.Core.Data.ChessDetailClass.MaxPlayers,
            NoPlayers = Chess.Core.Data.ChessDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Chess.Core.Data.ChessDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Chess.Core.Data.ChessDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Chinazo.Core.Data.ChinazoDetailClass.GameName,
            SupportsCompactLayout = Chinazo.Core.Data.ChinazoDetailClass.SupportsCompactLayout,
            MinPlayers = Chinazo.Core.Data.ChinazoDetailClass.MinPlayers,
            MaxPlayers = Chinazo.Core.Data.ChinazoDetailClass.MaxPlayers,
            NoPlayers = Chinazo.Core.Data.ChinazoDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Chinazo.Core.Data.ChinazoDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Chinazo.Core.Data.ChinazoDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = ChineseCheckers.Core.Data.ChineseCheckersDetailClass.GameName,
            SupportsCompactLayout = ChineseCheckers.Core.Data.ChineseCheckersDetailClass.SupportsCompactLayout,
            MinPlayers = ChineseCheckers.Core.Data.ChineseCheckersDetailClass.MinPlayers,
            MaxPlayers = ChineseCheckers.Core.Data.ChineseCheckersDetailClass.MaxPlayers,
            NoPlayers = ChineseCheckers.Core.Data.ChineseCheckersDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = ChineseCheckers.Core.Data.ChineseCheckersDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = ChineseCheckers.Core.Data.ChineseCheckersDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = ClueBoardGame.Core.Data.ClueBoardGameDetailClass.GameName,
            SupportsCompactLayout = ClueBoardGame.Core.Data.ClueBoardGameDetailClass.SupportsCompactLayout,
            MinPlayers = ClueBoardGame.Core.Data.ClueBoardGameDetailClass.MinPlayers,
            MaxPlayers = ClueBoardGame.Core.Data.ClueBoardGameDetailClass.MaxPlayers,
            NoPlayers = ClueBoardGame.Core.Data.ClueBoardGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = ClueBoardGame.Core.Data.ClueBoardGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = ClueBoardGame.Core.Data.ClueBoardGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = ClueCardGame.Core.Data.ClueCardGameDetailClass.GameName,
            SupportsCompactLayout = ClueCardGame.Core.Data.ClueCardGameDetailClass.SupportsCompactLayout,
            MinPlayers = ClueCardGame.Core.Data.ClueCardGameDetailClass.MinPlayers,
            MaxPlayers = ClueCardGame.Core.Data.ClueCardGameDetailClass.MaxPlayers,
            NoPlayers = ClueCardGame.Core.Data.ClueCardGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = ClueCardGame.Core.Data.ClueCardGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = ClueCardGame.Core.Data.ClueCardGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Concentration.Core.Data.ConcentrationDetailClass.GameName,
            SupportsCompactLayout = Concentration.Core.Data.ConcentrationDetailClass.SupportsCompactLayout,
            MinPlayers = Concentration.Core.Data.ConcentrationDetailClass.MinPlayers,
            MaxPlayers = Concentration.Core.Data.ConcentrationDetailClass.MaxPlayers,
            NoPlayers = Concentration.Core.Data.ConcentrationDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Concentration.Core.Data.ConcentrationDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Concentration.Core.Data.ConcentrationDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = ConnectFour.Core.Data.ConnectFourDetailClass.GameName,
            SupportsCompactLayout = ConnectFour.Core.Data.ConnectFourDetailClass.SupportsCompactLayout,
            MinPlayers = ConnectFour.Core.Data.ConnectFourDetailClass.MinPlayers,
            MaxPlayers = ConnectFour.Core.Data.ConnectFourDetailClass.MaxPlayers,
            NoPlayers = ConnectFour.Core.Data.ConnectFourDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = ConnectFour.Core.Data.ConnectFourDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = ConnectFour.Core.Data.ConnectFourDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = ConnectTheDots.Core.Data.ConnectTheDotsDetailClass.GameName,
            SupportsCompactLayout = ConnectTheDots.Core.Data.ConnectTheDotsDetailClass.SupportsCompactLayout,
            MinPlayers = ConnectTheDots.Core.Data.ConnectTheDotsDetailClass.MinPlayers,
            MaxPlayers = ConnectTheDots.Core.Data.ConnectTheDotsDetailClass.MaxPlayers,
            NoPlayers = ConnectTheDots.Core.Data.ConnectTheDotsDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = ConnectTheDots.Core.Data.ConnectTheDotsDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = ConnectTheDots.Core.Data.ConnectTheDotsDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Countdown.Core.Data.CountdownDetailClass.GameName,
            SupportsCompactLayout = Countdown.Core.Data.CountdownDetailClass.SupportsCompactLayout,
            MinPlayers = Countdown.Core.Data.CountdownDetailClass.MinPlayers,
            MaxPlayers = Countdown.Core.Data.CountdownDetailClass.MaxPlayers,
            NoPlayers = Countdown.Core.Data.CountdownDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Countdown.Core.Data.CountdownDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Countdown.Core.Data.CountdownDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = CousinRummy.Core.Data.CousinRummyDetailClass.GameName,
            SupportsCompactLayout = CousinRummy.Core.Data.CousinRummyDetailClass.SupportsCompactLayout,
            MinPlayers = CousinRummy.Core.Data.CousinRummyDetailClass.MinPlayers,
            MaxPlayers = CousinRummy.Core.Data.CousinRummyDetailClass.MaxPlayers,
            NoPlayers = CousinRummy.Core.Data.CousinRummyDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = CousinRummy.Core.Data.CousinRummyDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = CousinRummy.Core.Data.CousinRummyDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = CoveredUp.Core.Data.CoveredUpDetailClass.GameName,
            SupportsCompactLayout = CoveredUp.Core.Data.CoveredUpDetailClass.SupportsCompactLayout,
            MinPlayers = CoveredUp.Core.Data.CoveredUpDetailClass.MinPlayers,
            MaxPlayers = CoveredUp.Core.Data.CoveredUpDetailClass.MaxPlayers,
            NoPlayers = CoveredUp.Core.Data.CoveredUpDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = CoveredUp.Core.Data.CoveredUpDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = CoveredUp.Core.Data.CoveredUpDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = CrazyEights.Core.Data.CrazyEightsDetailClass.GameName,
            SupportsCompactLayout = CrazyEights.Core.Data.CrazyEightsDetailClass.SupportsCompactLayout,
            MinPlayers = CrazyEights.Core.Data.CrazyEightsDetailClass.MinPlayers,
            MaxPlayers = CrazyEights.Core.Data.CrazyEightsDetailClass.MaxPlayers,
            NoPlayers = CrazyEights.Core.Data.CrazyEightsDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = CrazyEights.Core.Data.CrazyEightsDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = CrazyEights.Core.Data.CrazyEightsDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Cribbage.Core.Data.CribbageDetailClass.GameName,
            SupportsCompactLayout = Cribbage.Core.Data.CribbageDetailClass.SupportsCompactLayout,
            MinPlayers = Cribbage.Core.Data.CribbageDetailClass.MinPlayers,
            MaxPlayers = Cribbage.Core.Data.CribbageDetailClass.MaxPlayers,
            NoPlayers = Cribbage.Core.Data.CribbageDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Cribbage.Core.Data.CribbageDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Cribbage.Core.Data.CribbageDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = DeadDie96.Core.Data.DeadDie96DetailClass.GameName,
            SupportsCompactLayout = DeadDie96.Core.Data.DeadDie96DetailClass.SupportsCompactLayout,
            MinPlayers = DeadDie96.Core.Data.DeadDie96DetailClass.MinPlayers,
            MaxPlayers = DeadDie96.Core.Data.DeadDie96DetailClass.MaxPlayers,
            NoPlayers = DeadDie96.Core.Data.DeadDie96DetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = DeadDie96.Core.Data.DeadDie96DetailClass.CanHaveExtraComputerPlayers,
            PlayerType = DeadDie96.Core.Data.DeadDie96DetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = DealCardGame.Core.Data.DealCardGameDetailClass.GameName,
            SupportsCompactLayout = DealCardGame.Core.Data.DealCardGameDetailClass.SupportsCompactLayout,
            MinPlayers = DealCardGame.Core.Data.DealCardGameDetailClass.MinPlayers,
            MaxPlayers = DealCardGame.Core.Data.DealCardGameDetailClass.MaxPlayers,
            NoPlayers = DealCardGame.Core.Data.DealCardGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = DealCardGame.Core.Data.DealCardGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = DealCardGame.Core.Data.DealCardGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = DiceDominos.Core.Data.DiceDominosDetailClass.GameName,
            SupportsCompactLayout = DiceDominos.Core.Data.DiceDominosDetailClass.SupportsCompactLayout,
            MinPlayers = DiceDominos.Core.Data.DiceDominosDetailClass.MinPlayers,
            MaxPlayers = DiceDominos.Core.Data.DiceDominosDetailClass.MaxPlayers,
            NoPlayers = DiceDominos.Core.Data.DiceDominosDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = DiceDominos.Core.Data.DiceDominosDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = DiceDominos.Core.Data.DiceDominosDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = DominosRegular.Core.Data.DominosRegularDetailClass.GameName,
            SupportsCompactLayout = DominosRegular.Core.Data.DominosRegularDetailClass.SupportsCompactLayout,
            MinPlayers = DominosRegular.Core.Data.DominosRegularDetailClass.MinPlayers,
            MaxPlayers = DominosRegular.Core.Data.DominosRegularDetailClass.MaxPlayers,
            NoPlayers = DominosRegular.Core.Data.DominosRegularDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = DominosRegular.Core.Data.DominosRegularDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = DominosRegular.Core.Data.DominosRegularDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = DummyRummy.Core.Data.DummyRummyDetailClass.GameName,
            SupportsCompactLayout = DummyRummy.Core.Data.DummyRummyDetailClass.SupportsCompactLayout,
            MinPlayers = DummyRummy.Core.Data.DummyRummyDetailClass.MinPlayers,
            MaxPlayers = DummyRummy.Core.Data.DummyRummyDetailClass.MaxPlayers,
            NoPlayers = DummyRummy.Core.Data.DummyRummyDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = DummyRummy.Core.Data.DummyRummyDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = DummyRummy.Core.Data.DummyRummyDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = DutchBlitz.Core.Data.DutchBlitzDetailClass.GameName,
            SupportsCompactLayout = DutchBlitz.Core.Data.DutchBlitzDetailClass.SupportsCompactLayout,
            MinPlayers = DutchBlitz.Core.Data.DutchBlitzDetailClass.MinPlayers,
            MaxPlayers = DutchBlitz.Core.Data.DutchBlitzDetailClass.MaxPlayers,
            NoPlayers = DutchBlitz.Core.Data.DutchBlitzDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = DutchBlitz.Core.Data.DutchBlitzDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = DutchBlitz.Core.Data.DutchBlitzDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = FillOrBust.Core.Data.FillOrBustDetailClass.GameName,
            SupportsCompactLayout = FillOrBust.Core.Data.FillOrBustDetailClass.SupportsCompactLayout,
            MinPlayers = FillOrBust.Core.Data.FillOrBustDetailClass.MinPlayers,
            MaxPlayers = FillOrBust.Core.Data.FillOrBustDetailClass.MaxPlayers,
            NoPlayers = FillOrBust.Core.Data.FillOrBustDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = FillOrBust.Core.Data.FillOrBustDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = FillOrBust.Core.Data.FillOrBustDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = FiveCrowns.Core.Data.FiveCrownsDetailClass.GameName,
            SupportsCompactLayout = FiveCrowns.Core.Data.FiveCrownsDetailClass.SupportsCompactLayout,
            MinPlayers = FiveCrowns.Core.Data.FiveCrownsDetailClass.MinPlayers,
            MaxPlayers = FiveCrowns.Core.Data.FiveCrownsDetailClass.MaxPlayers,
            NoPlayers = FiveCrowns.Core.Data.FiveCrownsDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = FiveCrowns.Core.Data.FiveCrownsDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = FiveCrowns.Core.Data.FiveCrownsDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Flinch.Core.Data.FlinchDetailClass.GameName,
            SupportsCompactLayout = Flinch.Core.Data.FlinchDetailClass.SupportsCompactLayout,
            MinPlayers = Flinch.Core.Data.FlinchDetailClass.MinPlayers,
            MaxPlayers = Flinch.Core.Data.FlinchDetailClass.MaxPlayers,
            NoPlayers = Flinch.Core.Data.FlinchDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Flinch.Core.Data.FlinchDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Flinch.Core.Data.FlinchDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Fluxx.Core.Data.FluxxDetailClass.GameName,
            SupportsCompactLayout = Fluxx.Core.Data.FluxxDetailClass.SupportsCompactLayout,
            MinPlayers = Fluxx.Core.Data.FluxxDetailClass.MinPlayers,
            MaxPlayers = Fluxx.Core.Data.FluxxDetailClass.MaxPlayers,
            NoPlayers = Fluxx.Core.Data.FluxxDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Fluxx.Core.Data.FluxxDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Fluxx.Core.Data.FluxxDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = FourSuitRummy.Core.Data.FourSuitRummyDetailClass.GameName,
            SupportsCompactLayout = FourSuitRummy.Core.Data.FourSuitRummyDetailClass.SupportsCompactLayout,
            MinPlayers = FourSuitRummy.Core.Data.FourSuitRummyDetailClass.MinPlayers,
            MaxPlayers = FourSuitRummy.Core.Data.FourSuitRummyDetailClass.MaxPlayers,
            NoPlayers = FourSuitRummy.Core.Data.FourSuitRummyDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = FourSuitRummy.Core.Data.FourSuitRummyDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = FourSuitRummy.Core.Data.FourSuitRummyDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = GalaxyCardGame.Core.Data.GalaxyCardGameDetailClass.GameName,
            SupportsCompactLayout = GalaxyCardGame.Core.Data.GalaxyCardGameDetailClass.SupportsCompactLayout,
            MinPlayers = GalaxyCardGame.Core.Data.GalaxyCardGameDetailClass.MinPlayers,
            MaxPlayers = GalaxyCardGame.Core.Data.GalaxyCardGameDetailClass.MaxPlayers,
            NoPlayers = GalaxyCardGame.Core.Data.GalaxyCardGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = GalaxyCardGame.Core.Data.GalaxyCardGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = GalaxyCardGame.Core.Data.GalaxyCardGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = GermanWhist.Core.Data.GermanWhistDetailClass.GameName,
            SupportsCompactLayout = GermanWhist.Core.Data.GermanWhistDetailClass.SupportsCompactLayout,
            MinPlayers = GermanWhist.Core.Data.GermanWhistDetailClass.MinPlayers,
            MaxPlayers = GermanWhist.Core.Data.GermanWhistDetailClass.MaxPlayers,
            NoPlayers = GermanWhist.Core.Data.GermanWhistDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = GermanWhist.Core.Data.GermanWhistDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = GermanWhist.Core.Data.GermanWhistDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = GoFish.Core.Data.GoFishDetailClass.GameName,
            SupportsCompactLayout = GoFish.Core.Data.GoFishDetailClass.SupportsCompactLayout,
            MinPlayers = GoFish.Core.Data.GoFishDetailClass.MinPlayers,
            MaxPlayers = GoFish.Core.Data.GoFishDetailClass.MaxPlayers,
            NoPlayers = GoFish.Core.Data.GoFishDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = GoFish.Core.Data.GoFishDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = GoFish.Core.Data.GoFishDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = GolfCardGame.Core.Data.GolfCardGameDetailClass.GameName,
            SupportsCompactLayout = GolfCardGame.Core.Data.GolfCardGameDetailClass.SupportsCompactLayout,
            MinPlayers = GolfCardGame.Core.Data.GolfCardGameDetailClass.MinPlayers,
            MaxPlayers = GolfCardGame.Core.Data.GolfCardGameDetailClass.MaxPlayers,
            NoPlayers = GolfCardGame.Core.Data.GolfCardGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = GolfCardGame.Core.Data.GolfCardGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = GolfCardGame.Core.Data.GolfCardGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Hearts.Core.Data.HeartsDetailClass.GameName,
            SupportsCompactLayout = Hearts.Core.Data.HeartsDetailClass.SupportsCompactLayout,
            MinPlayers = Hearts.Core.Data.HeartsDetailClass.MinPlayers,
            MaxPlayers = Hearts.Core.Data.HeartsDetailClass.MaxPlayers,
            NoPlayers = Hearts.Core.Data.HeartsDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Hearts.Core.Data.HeartsDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Hearts.Core.Data.HeartsDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = HitTheDeck.Core.Data.HitTheDeckDetailClass.GameName,
            SupportsCompactLayout = HitTheDeck.Core.Data.HitTheDeckDetailClass.SupportsCompactLayout,
            MinPlayers = HitTheDeck.Core.Data.HitTheDeckDetailClass.MinPlayers,
            MaxPlayers = HitTheDeck.Core.Data.HitTheDeckDetailClass.MaxPlayers,
            NoPlayers = HitTheDeck.Core.Data.HitTheDeckDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = HitTheDeck.Core.Data.HitTheDeckDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = HitTheDeck.Core.Data.HitTheDeckDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = HorseshoeCardGame.Core.Data.HorseshoeCardGameDetailClass.GameName,
            SupportsCompactLayout = HorseshoeCardGame.Core.Data.HorseshoeCardGameDetailClass.SupportsCompactLayout,
            MinPlayers = HorseshoeCardGame.Core.Data.HorseshoeCardGameDetailClass.MinPlayers,
            MaxPlayers = HorseshoeCardGame.Core.Data.HorseshoeCardGameDetailClass.MaxPlayers,
            NoPlayers = HorseshoeCardGame.Core.Data.HorseshoeCardGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = HorseshoeCardGame.Core.Data.HorseshoeCardGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = HorseshoeCardGame.Core.Data.HorseshoeCardGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = HuseHearts.Core.Data.HuseHeartsDetailClass.GameName,
            SupportsCompactLayout = HuseHearts.Core.Data.HuseHeartsDetailClass.SupportsCompactLayout,
            MinPlayers = HuseHearts.Core.Data.HuseHeartsDetailClass.MinPlayers,
            MaxPlayers = HuseHearts.Core.Data.HuseHeartsDetailClass.MaxPlayers,
            NoPlayers = HuseHearts.Core.Data.HuseHeartsDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = HuseHearts.Core.Data.HuseHeartsDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = HuseHearts.Core.Data.HuseHeartsDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = ItalianDominos.Core.Data.ItalianDominosDetailClass.GameName,
            SupportsCompactLayout = ItalianDominos.Core.Data.ItalianDominosDetailClass.SupportsCompactLayout,
            MinPlayers = ItalianDominos.Core.Data.ItalianDominosDetailClass.MinPlayers,
            MaxPlayers = ItalianDominos.Core.Data.ItalianDominosDetailClass.MaxPlayers,
            NoPlayers = ItalianDominos.Core.Data.ItalianDominosDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = ItalianDominos.Core.Data.ItalianDominosDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = ItalianDominos.Core.Data.ItalianDominosDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Kismet.Core.Data.KismetDetailClass.GameName,
            SupportsCompactLayout = Kismet.Core.Data.KismetDetailClass.SupportsCompactLayout,
            MinPlayers = Kismet.Core.Data.KismetDetailClass.MinPlayers,
            MaxPlayers = Kismet.Core.Data.KismetDetailClass.MaxPlayers,
            NoPlayers = Kismet.Core.Data.KismetDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Kismet.Core.Data.KismetDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Kismet.Core.Data.KismetDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = LifeBoardGame.Core.Data.LifeBoardGameDetailClass.GameName,
            SupportsCompactLayout = LifeBoardGame.Core.Data.LifeBoardGameDetailClass.SupportsCompactLayout,
            MinPlayers = LifeBoardGame.Core.Data.LifeBoardGameDetailClass.MinPlayers,
            MaxPlayers = LifeBoardGame.Core.Data.LifeBoardGameDetailClass.MaxPlayers,
            NoPlayers = LifeBoardGame.Core.Data.LifeBoardGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = LifeBoardGame.Core.Data.LifeBoardGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = LifeBoardGame.Core.Data.LifeBoardGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = LifeCardGame.Core.Data.LifeCardGameDetailClass.GameName,
            SupportsCompactLayout = LifeCardGame.Core.Data.LifeCardGameDetailClass.SupportsCompactLayout,
            MinPlayers = LifeCardGame.Core.Data.LifeCardGameDetailClass.MinPlayers,
            MaxPlayers = LifeCardGame.Core.Data.LifeCardGameDetailClass.MaxPlayers,
            NoPlayers = LifeCardGame.Core.Data.LifeCardGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = LifeCardGame.Core.Data.LifeCardGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = LifeCardGame.Core.Data.LifeCardGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = LottoDominos.Core.Data.LottoDominosDetailClass.GameName,
            SupportsCompactLayout = LottoDominos.Core.Data.LottoDominosDetailClass.SupportsCompactLayout,
            MinPlayers = LottoDominos.Core.Data.LottoDominosDetailClass.MinPlayers,
            MaxPlayers = LottoDominos.Core.Data.LottoDominosDetailClass.MaxPlayers,
            NoPlayers = LottoDominos.Core.Data.LottoDominosDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = LottoDominos.Core.Data.LottoDominosDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = LottoDominos.Core.Data.LottoDominosDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Mancala.Core.Data.MancalaDetailClass.GameName,
            SupportsCompactLayout = Mancala.Core.Data.MancalaDetailClass.SupportsCompactLayout,
            MinPlayers = Mancala.Core.Data.MancalaDetailClass.MinPlayers,
            MaxPlayers = Mancala.Core.Data.MancalaDetailClass.MaxPlayers,
            NoPlayers = Mancala.Core.Data.MancalaDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Mancala.Core.Data.MancalaDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Mancala.Core.Data.MancalaDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = MilkRun.Core.Data.MilkRunDetailClass.GameName,
            SupportsCompactLayout = MilkRun.Core.Data.MilkRunDetailClass.SupportsCompactLayout,
            MinPlayers = MilkRun.Core.Data.MilkRunDetailClass.MinPlayers,
            MaxPlayers = MilkRun.Core.Data.MilkRunDetailClass.MaxPlayers,
            NoPlayers = MilkRun.Core.Data.MilkRunDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = MilkRun.Core.Data.MilkRunDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = MilkRun.Core.Data.MilkRunDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Millebournes.Core.Data.MillebournesDetailClass.GameName,
            SupportsCompactLayout = Millebournes.Core.Data.MillebournesDetailClass.SupportsCompactLayout,
            MinPlayers = Millebournes.Core.Data.MillebournesDetailClass.MinPlayers,
            MaxPlayers = Millebournes.Core.Data.MillebournesDetailClass.MaxPlayers,
            NoPlayers = Millebournes.Core.Data.MillebournesDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Millebournes.Core.Data.MillebournesDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Millebournes.Core.Data.MillebournesDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = MonasteryCardGame.Core.Data.MonasteryCardGameDetailClass.GameName,
            SupportsCompactLayout = MonasteryCardGame.Core.Data.MonasteryCardGameDetailClass.SupportsCompactLayout,
            MinPlayers = MonasteryCardGame.Core.Data.MonasteryCardGameDetailClass.MinPlayers,
            MaxPlayers = MonasteryCardGame.Core.Data.MonasteryCardGameDetailClass.MaxPlayers,
            NoPlayers = MonasteryCardGame.Core.Data.MonasteryCardGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = MonasteryCardGame.Core.Data.MonasteryCardGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = MonasteryCardGame.Core.Data.MonasteryCardGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = MonopolyCardGame.Core.Data.MonopolyCardGameDetailClass.GameName,
            SupportsCompactLayout = MonopolyCardGame.Core.Data.MonopolyCardGameDetailClass.SupportsCompactLayout,
            MinPlayers = MonopolyCardGame.Core.Data.MonopolyCardGameDetailClass.MinPlayers,
            MaxPlayers = MonopolyCardGame.Core.Data.MonopolyCardGameDetailClass.MaxPlayers,
            NoPlayers = MonopolyCardGame.Core.Data.MonopolyCardGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = MonopolyCardGame.Core.Data.MonopolyCardGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = MonopolyCardGame.Core.Data.MonopolyCardGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = MonopolyDicedGame.Core.Data.MonopolyDicedGameDetailClass.GameName,
            SupportsCompactLayout = MonopolyDicedGame.Core.Data.MonopolyDicedGameDetailClass.SupportsCompactLayout,
            MinPlayers = MonopolyDicedGame.Core.Data.MonopolyDicedGameDetailClass.MinPlayers,
            MaxPlayers = MonopolyDicedGame.Core.Data.MonopolyDicedGameDetailClass.MaxPlayers,
            NoPlayers = MonopolyDicedGame.Core.Data.MonopolyDicedGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = MonopolyDicedGame.Core.Data.MonopolyDicedGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = MonopolyDicedGame.Core.Data.MonopolyDicedGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = OldMaid.Core.Data.OldMaidDetailClass.GameName,
            SupportsCompactLayout = OldMaid.Core.Data.OldMaidDetailClass.SupportsCompactLayout,
            MinPlayers = OldMaid.Core.Data.OldMaidDetailClass.MinPlayers,
            MaxPlayers = OldMaid.Core.Data.OldMaidDetailClass.MaxPlayers,
            NoPlayers = OldMaid.Core.Data.OldMaidDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = OldMaid.Core.Data.OldMaidDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = OldMaid.Core.Data.OldMaidDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Opetong.Core.Data.OpetongDetailClass.GameName,
            SupportsCompactLayout = Opetong.Core.Data.OpetongDetailClass.SupportsCompactLayout,
            MinPlayers = Opetong.Core.Data.OpetongDetailClass.MinPlayers,
            MaxPlayers = Opetong.Core.Data.OpetongDetailClass.MaxPlayers,
            NoPlayers = Opetong.Core.Data.OpetongDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Opetong.Core.Data.OpetongDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Opetong.Core.Data.OpetongDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = PassOutDiceGame.Core.Data.PassOutDiceGameDetailClass.GameName,
            SupportsCompactLayout = PassOutDiceGame.Core.Data.PassOutDiceGameDetailClass.SupportsCompactLayout,
            MinPlayers = PassOutDiceGame.Core.Data.PassOutDiceGameDetailClass.MinPlayers,
            MaxPlayers = PassOutDiceGame.Core.Data.PassOutDiceGameDetailClass.MaxPlayers,
            NoPlayers = PassOutDiceGame.Core.Data.PassOutDiceGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = PassOutDiceGame.Core.Data.PassOutDiceGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = PassOutDiceGame.Core.Data.PassOutDiceGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Payday.Core.Data.PaydayDetailClass.GameName,
            SupportsCompactLayout = Payday.Core.Data.PaydayDetailClass.SupportsCompactLayout,
            MinPlayers = Payday.Core.Data.PaydayDetailClass.MinPlayers,
            MaxPlayers = Payday.Core.Data.PaydayDetailClass.MaxPlayers,
            NoPlayers = Payday.Core.Data.PaydayDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Payday.Core.Data.PaydayDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Payday.Core.Data.PaydayDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Phase10.Core.Data.Phase10DetailClass.GameName,
            SupportsCompactLayout = Phase10.Core.Data.Phase10DetailClass.SupportsCompactLayout,
            MinPlayers = Phase10.Core.Data.Phase10DetailClass.MinPlayers,
            MaxPlayers = Phase10.Core.Data.Phase10DetailClass.MaxPlayers,
            NoPlayers = Phase10.Core.Data.Phase10DetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Phase10.Core.Data.Phase10DetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Phase10.Core.Data.Phase10DetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = PickelCardGame.Core.Data.PickelCardGameDetailClass.GameName,
            SupportsCompactLayout = PickelCardGame.Core.Data.PickelCardGameDetailClass.SupportsCompactLayout,
            MinPlayers = PickelCardGame.Core.Data.PickelCardGameDetailClass.MinPlayers,
            MaxPlayers = PickelCardGame.Core.Data.PickelCardGameDetailClass.MaxPlayers,
            NoPlayers = PickelCardGame.Core.Data.PickelCardGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = PickelCardGame.Core.Data.PickelCardGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = PickelCardGame.Core.Data.PickelCardGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Pinochle2Player.Core.Data.Pinochle2PlayerDetailClass.GameName,
            SupportsCompactLayout = Pinochle2Player.Core.Data.Pinochle2PlayerDetailClass.SupportsCompactLayout,
            MinPlayers = Pinochle2Player.Core.Data.Pinochle2PlayerDetailClass.MinPlayers,
            MaxPlayers = Pinochle2Player.Core.Data.Pinochle2PlayerDetailClass.MaxPlayers,
            NoPlayers = Pinochle2Player.Core.Data.Pinochle2PlayerDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Pinochle2Player.Core.Data.Pinochle2PlayerDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Pinochle2Player.Core.Data.Pinochle2PlayerDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Racko.Core.Data.RackoDetailClass.GameName,
            SupportsCompactLayout = Racko.Core.Data.RackoDetailClass.SupportsCompactLayout,
            MinPlayers = Racko.Core.Data.RackoDetailClass.MinPlayers,
            MaxPlayers = Racko.Core.Data.RackoDetailClass.MaxPlayers,
            NoPlayers = Racko.Core.Data.RackoDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Racko.Core.Data.RackoDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Racko.Core.Data.RackoDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = RageCardGame.Core.Data.RageCardGameDetailClass.GameName,
            SupportsCompactLayout = RageCardGame.Core.Data.RageCardGameDetailClass.SupportsCompactLayout,
            MinPlayers = RageCardGame.Core.Data.RageCardGameDetailClass.MinPlayers,
            MaxPlayers = RageCardGame.Core.Data.RageCardGameDetailClass.MaxPlayers,
            NoPlayers = RageCardGame.Core.Data.RageCardGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = RageCardGame.Core.Data.RageCardGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = RageCardGame.Core.Data.RageCardGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Risk.Core.Data.RiskDetailClass.GameName,
            SupportsCompactLayout = Risk.Core.Data.RiskDetailClass.SupportsCompactLayout,
            MinPlayers = Risk.Core.Data.RiskDetailClass.MinPlayers,
            MaxPlayers = Risk.Core.Data.RiskDetailClass.MaxPlayers,
            NoPlayers = Risk.Core.Data.RiskDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Risk.Core.Data.RiskDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Risk.Core.Data.RiskDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = RollEm.Core.Data.RollEmDetailClass.GameName,
            SupportsCompactLayout = RollEm.Core.Data.RollEmDetailClass.SupportsCompactLayout,
            MinPlayers = RollEm.Core.Data.RollEmDetailClass.MinPlayers,
            MaxPlayers = RollEm.Core.Data.RollEmDetailClass.MaxPlayers,
            NoPlayers = RollEm.Core.Data.RollEmDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = RollEm.Core.Data.RollEmDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = RollEm.Core.Data.RollEmDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Rook.Core.Data.RookDetailClass.GameName,
            SupportsCompactLayout = Rook.Core.Data.RookDetailClass.SupportsCompactLayout,
            MinPlayers = Rook.Core.Data.RookDetailClass.MinPlayers,
            MaxPlayers = Rook.Core.Data.RookDetailClass.MaxPlayers,
            NoPlayers = Rook.Core.Data.RookDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Rook.Core.Data.RookDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Rook.Core.Data.RookDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = RoundsCardGame.Core.Data.RoundsCardGameDetailClass.GameName,
            SupportsCompactLayout = RoundsCardGame.Core.Data.RoundsCardGameDetailClass.SupportsCompactLayout,
            MinPlayers = RoundsCardGame.Core.Data.RoundsCardGameDetailClass.MinPlayers,
            MaxPlayers = RoundsCardGame.Core.Data.RoundsCardGameDetailClass.MaxPlayers,
            NoPlayers = RoundsCardGame.Core.Data.RoundsCardGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = RoundsCardGame.Core.Data.RoundsCardGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = RoundsCardGame.Core.Data.RoundsCardGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = RummyDice.Core.Data.RummyDiceDetailClass.GameName,
            SupportsCompactLayout = RummyDice.Core.Data.RummyDiceDetailClass.SupportsCompactLayout,
            MinPlayers = RummyDice.Core.Data.RummyDiceDetailClass.MinPlayers,
            MaxPlayers = RummyDice.Core.Data.RummyDiceDetailClass.MaxPlayers,
            NoPlayers = RummyDice.Core.Data.RummyDiceDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = RummyDice.Core.Data.RummyDiceDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = RummyDice.Core.Data.RummyDiceDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Rummy500.Core.Data.Rummy500DetailClass.GameName,
            SupportsCompactLayout = Rummy500.Core.Data.Rummy500DetailClass.SupportsCompactLayout,
            MinPlayers = Rummy500.Core.Data.Rummy500DetailClass.MinPlayers,
            MaxPlayers = Rummy500.Core.Data.Rummy500DetailClass.MaxPlayers,
            NoPlayers = Rummy500.Core.Data.Rummy500DetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Rummy500.Core.Data.Rummy500DetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Rummy500.Core.Data.Rummy500DetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Savannah.Core.Data.SavannahDetailClass.GameName,
            SupportsCompactLayout = Savannah.Core.Data.SavannahDetailClass.SupportsCompactLayout,
            MinPlayers = Savannah.Core.Data.SavannahDetailClass.MinPlayers,
            MaxPlayers = Savannah.Core.Data.SavannahDetailClass.MaxPlayers,
            NoPlayers = Savannah.Core.Data.SavannahDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Savannah.Core.Data.SavannahDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Savannah.Core.Data.SavannahDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = SequenceDice.Core.Data.SequenceDiceDetailClass.GameName,
            SupportsCompactLayout = SequenceDice.Core.Data.SequenceDiceDetailClass.SupportsCompactLayout,
            MinPlayers = SequenceDice.Core.Data.SequenceDiceDetailClass.MinPlayers,
            MaxPlayers = SequenceDice.Core.Data.SequenceDiceDetailClass.MaxPlayers,
            NoPlayers = SequenceDice.Core.Data.SequenceDiceDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = SequenceDice.Core.Data.SequenceDiceDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = SequenceDice.Core.Data.SequenceDiceDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = ShipCaptainCrew.Core.Data.ShipCaptainCrewDetailClass.GameName,
            SupportsCompactLayout = ShipCaptainCrew.Core.Data.ShipCaptainCrewDetailClass.SupportsCompactLayout,
            MinPlayers = ShipCaptainCrew.Core.Data.ShipCaptainCrewDetailClass.MinPlayers,
            MaxPlayers = ShipCaptainCrew.Core.Data.ShipCaptainCrewDetailClass.MaxPlayers,
            NoPlayers = ShipCaptainCrew.Core.Data.ShipCaptainCrewDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = ShipCaptainCrew.Core.Data.ShipCaptainCrewDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = ShipCaptainCrew.Core.Data.ShipCaptainCrewDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = SinisterSix.Core.Data.SinisterSixDetailClass.GameName,
            SupportsCompactLayout = SinisterSix.Core.Data.SinisterSixDetailClass.SupportsCompactLayout,
            MinPlayers = SinisterSix.Core.Data.SinisterSixDetailClass.MinPlayers,
            MaxPlayers = SinisterSix.Core.Data.SinisterSixDetailClass.MaxPlayers,
            NoPlayers = SinisterSix.Core.Data.SinisterSixDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = SinisterSix.Core.Data.SinisterSixDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = SinisterSix.Core.Data.SinisterSixDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = SixtySix2Player.Core.Data.SixtySix2PlayerDetailClass.GameName,
            SupportsCompactLayout = SixtySix2Player.Core.Data.SixtySix2PlayerDetailClass.SupportsCompactLayout,
            MinPlayers = SixtySix2Player.Core.Data.SixtySix2PlayerDetailClass.MinPlayers,
            MaxPlayers = SixtySix2Player.Core.Data.SixtySix2PlayerDetailClass.MaxPlayers,
            NoPlayers = SixtySix2Player.Core.Data.SixtySix2PlayerDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = SixtySix2Player.Core.Data.SixtySix2PlayerDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = SixtySix2Player.Core.Data.SixtySix2PlayerDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Skipbo.Core.Data.SkipboDetailClass.GameName,
            SupportsCompactLayout = Skipbo.Core.Data.SkipboDetailClass.SupportsCompactLayout,
            MinPlayers = Skipbo.Core.Data.SkipboDetailClass.MinPlayers,
            MaxPlayers = Skipbo.Core.Data.SkipboDetailClass.MaxPlayers,
            NoPlayers = Skipbo.Core.Data.SkipboDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Skipbo.Core.Data.SkipboDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Skipbo.Core.Data.SkipboDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = SkuckCardGame.Core.Data.SkuckCardGameDetailClass.GameName,
            SupportsCompactLayout = SkuckCardGame.Core.Data.SkuckCardGameDetailClass.SupportsCompactLayout,
            MinPlayers = SkuckCardGame.Core.Data.SkuckCardGameDetailClass.MinPlayers,
            MaxPlayers = SkuckCardGame.Core.Data.SkuckCardGameDetailClass.MaxPlayers,
            NoPlayers = SkuckCardGame.Core.Data.SkuckCardGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = SkuckCardGame.Core.Data.SkuckCardGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = SkuckCardGame.Core.Data.SkuckCardGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = SnagCardGame.Core.Data.SnagCardGameDetailClass.GameName,
            SupportsCompactLayout = SnagCardGame.Core.Data.SnagCardGameDetailClass.SupportsCompactLayout,
            MinPlayers = SnagCardGame.Core.Data.SnagCardGameDetailClass.MinPlayers,
            MaxPlayers = SnagCardGame.Core.Data.SnagCardGameDetailClass.MaxPlayers,
            NoPlayers = SnagCardGame.Core.Data.SnagCardGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = SnagCardGame.Core.Data.SnagCardGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = SnagCardGame.Core.Data.SnagCardGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = SnakesAndLadders.Core.Data.SnakesAndLaddersDetailClass.GameName,
            SupportsCompactLayout = SnakesAndLadders.Core.Data.SnakesAndLaddersDetailClass.SupportsCompactLayout,
            MinPlayers = SnakesAndLadders.Core.Data.SnakesAndLaddersDetailClass.MinPlayers,
            MaxPlayers = SnakesAndLadders.Core.Data.SnakesAndLaddersDetailClass.MaxPlayers,
            NoPlayers = SnakesAndLadders.Core.Data.SnakesAndLaddersDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = SnakesAndLadders.Core.Data.SnakesAndLaddersDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = SnakesAndLadders.Core.Data.SnakesAndLaddersDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Sorry.Core.Data.SorryDetailClass.GameName,
            SupportsCompactLayout = Sorry.Core.Data.SorryDetailClass.SupportsCompactLayout,
            MinPlayers = Sorry.Core.Data.SorryDetailClass.MinPlayers,
            MaxPlayers = Sorry.Core.Data.SorryDetailClass.MaxPlayers,
            NoPlayers = Sorry.Core.Data.SorryDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Sorry.Core.Data.SorryDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Sorry.Core.Data.SorryDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = SorryCardGame.Core.Data.SorryCardGameDetailClass.GameName,
            SupportsCompactLayout = SorryCardGame.Core.Data.SorryCardGameDetailClass.SupportsCompactLayout,
            MinPlayers = SorryCardGame.Core.Data.SorryCardGameDetailClass.MinPlayers,
            MaxPlayers = SorryCardGame.Core.Data.SorryCardGameDetailClass.MaxPlayers,
            NoPlayers = SorryCardGame.Core.Data.SorryCardGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = SorryCardGame.Core.Data.SorryCardGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = SorryCardGame.Core.Data.SorryCardGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = SorryDicedGame.Core.Data.SorryDicedGameDetailClass.GameName,
            SupportsCompactLayout = SorryDicedGame.Core.Data.SorryDicedGameDetailClass.SupportsCompactLayout,
            MinPlayers = SorryDicedGame.Core.Data.SorryDicedGameDetailClass.MinPlayers,
            MaxPlayers = SorryDicedGame.Core.Data.SorryDicedGameDetailClass.MaxPlayers,
            NoPlayers = SorryDicedGame.Core.Data.SorryDicedGameDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = SorryDicedGame.Core.Data.SorryDicedGameDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = SorryDicedGame.Core.Data.SorryDicedGameDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Spades2Player.Core.Data.Spades2PlayerDetailClass.GameName,
            SupportsCompactLayout = Spades2Player.Core.Data.Spades2PlayerDetailClass.SupportsCompactLayout,
            MinPlayers = Spades2Player.Core.Data.Spades2PlayerDetailClass.MinPlayers,
            MaxPlayers = Spades2Player.Core.Data.Spades2PlayerDetailClass.MaxPlayers,
            NoPlayers = Spades2Player.Core.Data.Spades2PlayerDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Spades2Player.Core.Data.Spades2PlayerDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Spades2Player.Core.Data.Spades2PlayerDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Spades4Player.Core.Data.Spades4PlayerDetailClass.GameName,
            SupportsCompactLayout = Spades4Player.Core.Data.Spades4PlayerDetailClass.SupportsCompactLayout,
            MinPlayers = Spades4Player.Core.Data.Spades4PlayerDetailClass.MinPlayers,
            MaxPlayers = Spades4Player.Core.Data.Spades4PlayerDetailClass.MaxPlayers,
            NoPlayers = Spades4Player.Core.Data.Spades4PlayerDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Spades4Player.Core.Data.Spades4PlayerDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Spades4Player.Core.Data.Spades4PlayerDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = TeeItUp.Core.Data.TeeItUpDetailClass.GameName,
            SupportsCompactLayout = TeeItUp.Core.Data.TeeItUpDetailClass.SupportsCompactLayout,
            MinPlayers = TeeItUp.Core.Data.TeeItUpDetailClass.MinPlayers,
            MaxPlayers = TeeItUp.Core.Data.TeeItUpDetailClass.MaxPlayers,
            NoPlayers = TeeItUp.Core.Data.TeeItUpDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = TeeItUp.Core.Data.TeeItUpDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = TeeItUp.Core.Data.TeeItUpDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = ThinkTwice.Core.Data.ThinkTwiceDetailClass.GameName,
            SupportsCompactLayout = ThinkTwice.Core.Data.ThinkTwiceDetailClass.SupportsCompactLayout,
            MinPlayers = ThinkTwice.Core.Data.ThinkTwiceDetailClass.MinPlayers,
            MaxPlayers = ThinkTwice.Core.Data.ThinkTwiceDetailClass.MaxPlayers,
            NoPlayers = ThinkTwice.Core.Data.ThinkTwiceDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = ThinkTwice.Core.Data.ThinkTwiceDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = ThinkTwice.Core.Data.ThinkTwiceDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = ThreeLetterFun.Core.Data.ThreeLetterFunDetailClass.GameName,
            SupportsCompactLayout = ThreeLetterFun.Core.Data.ThreeLetterFunDetailClass.SupportsCompactLayout,
            MinPlayers = ThreeLetterFun.Core.Data.ThreeLetterFunDetailClass.MinPlayers,
            MaxPlayers = ThreeLetterFun.Core.Data.ThreeLetterFunDetailClass.MaxPlayers,
            NoPlayers = ThreeLetterFun.Core.Data.ThreeLetterFunDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = ThreeLetterFun.Core.Data.ThreeLetterFunDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = ThreeLetterFun.Core.Data.ThreeLetterFunDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = TicTacToe.Core.Data.TicTacToeDetailClass.GameName,
            SupportsCompactLayout = TicTacToe.Core.Data.TicTacToeDetailClass.SupportsCompactLayout,
            MinPlayers = TicTacToe.Core.Data.TicTacToeDetailClass.MinPlayers,
            MaxPlayers = TicTacToe.Core.Data.TicTacToeDetailClass.MaxPlayers,
            NoPlayers = TicTacToe.Core.Data.TicTacToeDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = TicTacToe.Core.Data.TicTacToeDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = TicTacToe.Core.Data.TicTacToeDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = TileRummy.Core.Data.TileRummyDetailClass.GameName,
            SupportsCompactLayout = TileRummy.Core.Data.TileRummyDetailClass.SupportsCompactLayout,
            MinPlayers = TileRummy.Core.Data.TileRummyDetailClass.MinPlayers,
            MaxPlayers = TileRummy.Core.Data.TileRummyDetailClass.MaxPlayers,
            NoPlayers = TileRummy.Core.Data.TileRummyDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = TileRummy.Core.Data.TileRummyDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = TileRummy.Core.Data.TileRummyDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Trouble.Core.Data.TroubleDetailClass.GameName,
            SupportsCompactLayout = Trouble.Core.Data.TroubleDetailClass.SupportsCompactLayout,
            MinPlayers = Trouble.Core.Data.TroubleDetailClass.MinPlayers,
            MaxPlayers = Trouble.Core.Data.TroubleDetailClass.MaxPlayers,
            NoPlayers = Trouble.Core.Data.TroubleDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Trouble.Core.Data.TroubleDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Trouble.Core.Data.TroubleDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Uno.Core.Data.UnoDetailClass.GameName,
            SupportsCompactLayout = Uno.Core.Data.UnoDetailClass.SupportsCompactLayout,
            MinPlayers = Uno.Core.Data.UnoDetailClass.MinPlayers,
            MaxPlayers = Uno.Core.Data.UnoDetailClass.MaxPlayers,
            NoPlayers = Uno.Core.Data.UnoDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Uno.Core.Data.UnoDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Uno.Core.Data.UnoDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Xactika.Core.Data.XactikaDetailClass.GameName,
            SupportsCompactLayout = Xactika.Core.Data.XactikaDetailClass.SupportsCompactLayout,
            MinPlayers = Xactika.Core.Data.XactikaDetailClass.MinPlayers,
            MaxPlayers = Xactika.Core.Data.XactikaDetailClass.MaxPlayers,
            NoPlayers = Xactika.Core.Data.XactikaDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Xactika.Core.Data.XactikaDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Xactika.Core.Data.XactikaDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = YaBlewIt.Core.Data.YaBlewItDetailClass.GameName,
            SupportsCompactLayout = YaBlewIt.Core.Data.YaBlewItDetailClass.SupportsCompactLayout,
            MinPlayers = YaBlewIt.Core.Data.YaBlewItDetailClass.MinPlayers,
            MaxPlayers = YaBlewIt.Core.Data.YaBlewItDetailClass.MaxPlayers,
            NoPlayers = YaBlewIt.Core.Data.YaBlewItDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = YaBlewIt.Core.Data.YaBlewItDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = YaBlewIt.Core.Data.YaBlewItDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = YachtRace.Core.Data.YachtRaceDetailClass.GameName,
            SupportsCompactLayout = YachtRace.Core.Data.YachtRaceDetailClass.SupportsCompactLayout,
            MinPlayers = YachtRace.Core.Data.YachtRaceDetailClass.MinPlayers,
            MaxPlayers = YachtRace.Core.Data.YachtRaceDetailClass.MaxPlayers,
            NoPlayers = YachtRace.Core.Data.YachtRaceDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = YachtRace.Core.Data.YachtRaceDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = YachtRace.Core.Data.YachtRaceDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = Yahtzee.Core.Data.YahtzeeDetailClass.GameName,
            SupportsCompactLayout = Yahtzee.Core.Data.YahtzeeDetailClass.SupportsCompactLayout,
            MinPlayers = Yahtzee.Core.Data.YahtzeeDetailClass.MinPlayers,
            MaxPlayers = Yahtzee.Core.Data.YahtzeeDetailClass.MaxPlayers,
            NoPlayers = Yahtzee.Core.Data.YahtzeeDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = Yahtzee.Core.Data.YahtzeeDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = Yahtzee.Core.Data.YahtzeeDetailClass.PlayerType
        });

        RegisterGame(new GameRegistration
        {
            GameName = YahtzeeHandsDown.Core.Data.YahtzeeHandsDownDetailClass.GameName,
            SupportsCompactLayout = YahtzeeHandsDown.Core.Data.YahtzeeHandsDownDetailClass.SupportsCompactLayout,
            MinPlayers = YahtzeeHandsDown.Core.Data.YahtzeeHandsDownDetailClass.MinPlayers,
            MaxPlayers = YahtzeeHandsDown.Core.Data.YahtzeeHandsDownDetailClass.MaxPlayers,
            NoPlayers = YahtzeeHandsDown.Core.Data.YahtzeeHandsDownDetailClass.NoPlayers,
            CanHaveExtraComputerPlayers = YahtzeeHandsDown.Core.Data.YahtzeeHandsDownDetailClass.CanHaveExtraComputerPlayers,
            PlayerType = YahtzeeHandsDown.Core.Data.YahtzeeHandsDownDetailClass.PlayerType
        });

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