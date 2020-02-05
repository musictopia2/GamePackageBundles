using CommonBasicStandardLibraries.CollectionClasses;
using CommonBasicStandardLibraries.Exceptions;
using GameLoaderWPF;
using System.Windows;
namespace MiscSpecializedCardGames.WPF
{
    class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            GameList = new CustomBasicList<string>() { "Dutch Blitz", "Flinch", "Fluxx", "Hit The Deck", "Life Card Game", "Milk Run", "Millebournes", "Monopoly Card Game", "SkipBo", "Sorry Card Game", "Tee It Up", "Uno", "Yahtzee Hands Down"};
        }
        protected override Window ChooseGame(string gameChosen)
        {
            if (gameChosen == "Dutch Blitz")
                return new DutchBlitzWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Flinch")
                return new FlinchWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Fluxx")
                return new FluxxWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Hit The Deck")
                return new HitTheDeckWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Life Card Game")
                return new LifeCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Milk Run")
                return new MilkRunWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Millebournes")
                return new MillebournesWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Monopoly Card Game")
                return new MonopolyCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "SkipBo")
                return new SkipboWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Sorry Card Game")
                return new SorryCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Tee It Up")
                return new TeeItUpWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Uno")
                return new UnoWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Yahtzee Hands Down")
                return new YahtzeeHandsDownWPF.GamePage(Starts!, Mode);
            throw new BasicBlankException($"No game found with the game of {gameChosen}");
        }
    }
}