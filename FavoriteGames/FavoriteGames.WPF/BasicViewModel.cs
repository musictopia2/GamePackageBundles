using CommonBasicStandardLibraries.CollectionClasses;
using CommonBasicStandardLibraries.Exceptions;
using GameLoaderWPF;
using System.Windows;
namespace FavoriteGames.WPF
{
    class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            GameList = new CustomBasicList<string>() { "8 Round Rummy", "Aggravation", "Blades Of Steel", "Cousin Rummy", "Fill Or Bust", "Five Crowns", "German Whist", "Hit The Deck", "Huse Hearts", "Kismet", "Life Board Game", "Millebournes", "Payday", "Phase 10", "Pickel Card Game", "Rage Card Game", "Rummy 500", "Rummy Dice", "SkipBo", "Skuck Card Game", "Sorry Card Game", "Sorry", "Spades (2 Player)", "Tee It Up", "Think Twice", "Trouble", "Uno", "Xactika"};
        }
        protected override Window ChooseGame(string gameChosen)
        {
            if (gameChosen == "8 Round Rummy")
                return new A8RoundRummyWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Aggravation")
                return new AggravationWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Blades Of Steel")
                return new BladesOfSteelWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Cousin Rummy")
                return new CousinRummyWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Fill Or Bust")
                return new FillOrBustWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Five Crowns")
                return new FiveCrownsWPF.GamePage(Starts!, Mode);
            if (gameChosen == "German Whist")
                return new GermanWhistWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Hit The Deck")
                return new HitTheDeckWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Huse Hearts")
                return new HuseHeartsWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Kismet")
                return new KismetWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Life Board Game")
                return new LifeBoardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Millebournes")
                return new MillebournesWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Payday")
                return new PaydayWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Phase 10")
                return new Phase10WPF.GamePage(Starts!, Mode);
            if (gameChosen == "Pickel Card Game")
                return new PickelCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Rage Card Game")
                return new RageCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Rummy 500")
                return new Rummy500WPF.GamePage(Starts!, Mode);
            if (gameChosen == "Rummy Dice")
                return new RummyDiceWPF.GamePage(Starts!, Mode);
            if (gameChosen == "SkipBo")
                return new SkipboWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Skuck Card Game")
                return new SkuckCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Sorry Card Game")
                return new SorryCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Sorry")
                return new SorryWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Spades (2 Player)")
                return new Spades2PlayerWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Tee It Up")
                return new TeeItUpWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Think Twice")
                return new ThinkTwiceWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Trouble")
                return new TroubleWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Uno")
                return new UnoWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Xactika")
                return new XactikaWPF.GamePage(Starts!, Mode);
            throw new BasicBlankException($"No game found with the game of {gameChosen}");
        }
    }
}