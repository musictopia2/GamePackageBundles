using CommonBasicStandardLibraries.CollectionClasses;
using GameLoaderXF;
using System.Threading.Tasks;
using BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses;
using static BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses.GlobalScreenClass;
namespace BoardGames
{
    public class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            if (ScreenUsed == EnumScreen.SmallPhone)
                GameList = new CustomBasicList<string>() { "Aggravation", "Backgammon", "Candyland", "Trouble"};
            else
                GameList = new CustomBasicList<string>() { "Aggravation", "Backgammon", "Candyland", "Clue Board Game", "Life Board Game", "Payday", "Sorry", "Trouble"};
        }
        protected override async Task ChooseAsync()
        {
            if (GameChosen == "Aggravation")
                await Navigation!.PushAsync(new AggravationXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Backgammon")
                await Navigation!.PushAsync(new BackgammonXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Candyland")
                await Navigation!.PushAsync(new CandylandXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Clue Board Game")
                await Navigation!.PushAsync(new ClueBoardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Life Board Game")
                await Navigation!.PushAsync(new LifeBoardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Payday")
                await Navigation!.PushAsync(new PaydayXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Sorry")
                await Navigation!.PushAsync(new SorryXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Trouble")
                await Navigation!.PushAsync(new TroubleXF.GamePage(Platform!, Starts!, Mode));
        }
    }
}