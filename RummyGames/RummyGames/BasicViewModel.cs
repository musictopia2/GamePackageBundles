using CommonBasicStandardLibraries.CollectionClasses;
using GameLoaderXF;
using System.Threading.Tasks;
using BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses;
using static BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses.GlobalScreenClass;
namespace RummyGames
{
    public class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            if (ScreenUsed == EnumScreen.SmallPhone)
                GameList = new CustomBasicList<string>() { "Opetong"};
            else
                GameList = new CustomBasicList<string>() { "8 Round Rummy", "Chinazo", "Cousin Rummy", "Dummy Rummy", "Five Crowns", "Four Suit Rummy", "Galaxy Card Game", "Monastery Card Game", "Opetong", "Phase 10", "Rummy 500", "Rummy Dice", "Tile Rummy"};
        }
        protected override async Task ChooseAsync()
        {
            if (GameChosen == "8 Round Rummy")
                await Navigation!.PushAsync(new A8RoundRummyXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Chinazo")
                await Navigation!.PushAsync(new ChinazoXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Cousin Rummy")
                await Navigation!.PushAsync(new CousinRummyXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Dummy Rummy")
                await Navigation!.PushAsync(new DummyRummyXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Five Crowns")
                await Navigation!.PushAsync(new FiveCrownsXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Four Suit Rummy")
                await Navigation!.PushAsync(new FourSuitRummyXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Galaxy Card Game")
                await Navigation!.PushAsync(new GalaxyCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Monastery Card Game")
                await Navigation!.PushAsync(new MonasteryCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Opetong")
                await Navigation!.PushAsync(new OpetongXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Phase 10")
                await Navigation!.PushAsync(new Phase10XF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Rummy 500")
                await Navigation!.PushAsync(new Rummy500XF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Rummy Dice")
                await Navigation!.PushAsync(new RummyDiceXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Tile Rummy")
                await Navigation!.PushAsync(new TileRummyXF.GamePage(Platform!, Starts!, Mode));
        }
    }
}