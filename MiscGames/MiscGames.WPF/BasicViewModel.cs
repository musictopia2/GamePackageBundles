using CommonBasicStandardLibraries.CollectionClasses;
using CommonBasicStandardLibraries.Exceptions;
using GameLoaderWPF;
using System.Windows;
namespace MiscGames.WPF
{
    class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            GameList = new CustomBasicList<string>() { "Battleship", "Bingo", "Blades Of Steel", "Concentration", "Crazy Eights", "Cribbage", "Dice Dominos", "Dominos (Mexican Train)", "Dominos (Regular)", "Go Fish", "Golf Card Game", "Italian Dominos", "Lotto Dominos", "Old Maid", "Racko", "Three Letter Fun"};
        }
        protected override Window ChooseGame(string gameChosen)
        {
            if (gameChosen == "Battleship")
                return new BattleshipWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Bingo")
                return new BingoWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Blades Of Steel")
                return new BladesOfSteelWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Concentration")
                return new ConcentrationWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Crazy Eights")
                return new CrazyEightsWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Cribbage")
                return new CribbageWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Dice Dominos")
                return new DiceDominosWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Dominos (Mexican Train)")
                return new DominosMexicanTrainWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Dominos (Regular)")
                return new DominosRegularWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Go Fish")
                return new GoFishWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Golf Card Game")
                return new GolfCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Italian Dominos")
                return new ItalianDominosWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Lotto Dominos")
                return new LottoDominosWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Old Maid")
                return new OldMaidWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Racko")
                return new RackoWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Three Letter Fun")
                return new ThreeLetterFunWPF.GamePage(Starts!, Mode);
            throw new BasicBlankException($"No game found with the game of {gameChosen}");
        }
    }
}