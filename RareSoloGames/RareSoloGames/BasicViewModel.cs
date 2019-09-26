using CommonBasicStandardLibraries.CollectionClasses;
using GameLoaderXF;
using System.Threading.Tasks;
using BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses;
using static BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses.GlobalScreenClass;
namespace RareSoloGames
{
    public class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            if (ScreenUsed == EnumScreen.SmallPhone)
                GameList = new CustomBasicList<string>() { "Agnes Solitaire", "Block Eleven Solitaire", "Calculation Solitaire", "Little Spider Solitaire", "Raglan Solitaire"};
            else
                GameList = new CustomBasicList<string>() { "Agnes Solitaire", "Alternation Solitaire", "Block Eleven Solitaire", "Calculation Solitaire", "Captive Queens Solitaire", "Demon Solitaire", "Little Spider Solitaire", "Raglan Solitaire"};
        }
        protected override async Task ChooseAsync()
        {
            if (GameChosen == "Accordian Solitaire")
                await Navigation!.PushAsync(new AccordianSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Agnes Solitaire")
                await Navigation!.PushAsync(new AgnesSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Alternation Solitaire")
                await Navigation!.PushAsync(new AlternationSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Block Eleven Solitaire")
                await Navigation!.PushAsync(new BlockElevenSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Calculation Solitaire")
                await Navigation!.PushAsync(new CalculationSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Captive Queens Solitaire")
                await Navigation!.PushAsync(new CaptiveQueensSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Demon Solitaire")
                await Navigation!.PushAsync(new DemonSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Little Spider Solitaire")
                await Navigation!.PushAsync(new LittleSpiderSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Raglan Solitaire")
                await Navigation!.PushAsync(new RaglanSolitaireXF.GamePage(Platform!, Starts!, Mode));
        }
    }
}