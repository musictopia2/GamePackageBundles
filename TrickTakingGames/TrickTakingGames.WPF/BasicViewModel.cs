using CommonBasicStandardLibraries.CollectionClasses;
using CommonBasicStandardLibraries.Exceptions;
using GameLoaderWPF;
using System.Windows;
namespace TrickTakingGames.WPF
{
    class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            GameList = new CustomBasicList<string>() { "California Jack", "Galaxy Card Game", "German Whist", "Horseshoe", "Huse Hearts", "Pickel Card Game", "Pinochle (2 Player)", "Rage Card Game", "Rook", "Rounds Card Game", "Sixty Six (2 Player)", "Skuck Card Game", "Snag Card Game", "Spades (2 Player)", "Xactika"};
        }
        protected override Window ChooseGame(string gameChosen)
        {
            if (gameChosen == "California Jack")
                return new CaliforniaJackWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Galaxy Card Game")
                return new GalaxyCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "German Whist")
                return new GermanWhistWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Horseshoe")
                return new HorseshoeCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Huse Hearts")
                return new HuseHeartsWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Pickel Card Game")
                return new PickelCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Pinochle (2 Player)")
                return new Pinochle2PlayerWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Rage Card Game")
                return new RageCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Rook")
                return new RookWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Rounds Card Game")
                return new RoundsCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Sixty Six (2 Player)")
                return new SixtySix2PlayerWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Skuck Card Game")
                return new SkuckCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Snag Card Game")
                return new SnagCardGameWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Spades (2 Player)")
                return new Spades2PlayerWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Xactika")
                return new XactikaWPF.GamePage(Starts!, Mode);
            throw new BasicBlankException($"No game found with the game of {gameChosen}");
        }
    }
}