using CommonBasicStandardLibraries.CollectionClasses;
using CommonBasicStandardLibraries.Exceptions;
using GameLoaderWPF;
using System.Windows;
namespace RareSoloGames.WPF
{
    class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            GameList = new CustomBasicList<string>() { "Accordian Solitaire", "Agnes Solitaire", "Alternation Solitaire", "Block Eleven Solitaire", "Calculation Solitaire", "Captive Queens Solitaire", "Demon Solitaire", "Little Spider Solitaire", "Raglan Solitaire"};
        }
        protected override Window ChooseGame(string gameChosen)
        {
            if (gameChosen == "Accordian Solitaire")
                return new AccordianSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Agnes Solitaire")
                return new AgnesSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Alternation Solitaire")
                return new AlternationSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Block Eleven Solitaire")
                return new BlockElevenSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Calculation Solitaire")
                return new CalculationSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Captive Queens Solitaire")
                return new CaptiveQueensSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Demon Solitaire")
                return new DemonSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Little Spider Solitaire")
                return new LittleSpiderSolitaireWPF.GamePage(Starts!, Mode);
            if (gameChosen == "Raglan Solitaire")
                return new RaglanSolitaireWPF.GamePage(Starts!, Mode);
            throw new BasicBlankException($"No game found with the game of {gameChosen}");
        }
    }
}