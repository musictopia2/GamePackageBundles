using CommonBasicStandardLibraries.CollectionClasses;
using GameLoaderXF;
using System.Threading.Tasks;
using BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses;
using static BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses.GlobalScreenClass;
namespace CommonSolitaireGames
{
    public class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            if (ScreenUsed == EnumScreen.SmallPhone)
                GameList = new CustomBasicList<string>() { "Carpet Solitaire", "Eagle Wings Solitaire", "Easy Go Solitaire", "Triangle Solitaire", "Vegas Solitaire"};
            else
                GameList = new CustomBasicList<string>() { "Carpet Solitaire", "Clock Solitaire", "Cribbage Patience", "Eagle Wings Solitaire", "Easy Go Solitaire", "Heap Solitaire", "Triangle Solitaire", "Vegas Solitaire"};
        }
        protected override async Task ChooseAsync()
        {
            if (GameChosen == "Carpet Solitaire")
                await Navigation!.PushAsync(new CarpetSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Clock Solitaire")
                await Navigation!.PushAsync(new ClockSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Cribbage Patience")
                await Navigation!.PushAsync(new CribbagePatienceXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Eagle Wings Solitaire")
                await Navigation!.PushAsync(new EagleWingsSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Easy Go Solitaire")
                await Navigation!.PushAsync(new EasyGoSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Heap Solitaire")
                await Navigation!.PushAsync(new HeapSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Triangle Solitaire")
                await Navigation!.PushAsync(new TriangleSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Vegas Solitaire")
                await Navigation!.PushAsync(new VegasSolitaireXF.GamePage(Platform!, Starts!, Mode));
        }
    }
}