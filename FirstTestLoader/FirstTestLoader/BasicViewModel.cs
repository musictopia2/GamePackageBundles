using CommonBasicStandardLibraries.CollectionClasses;
using GameLoaderXF;
using System.Threading.Tasks;
using BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses;
using static BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses.GlobalScreenClass;
namespace FirstTestLoader
{
    public class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            if (ScreenUsed == EnumScreen.SmallPhone)
                GameList = new CustomBasicList<string>() { "Millebournes", "Opetong"};
            else
                GameList = new CustomBasicList<string>() { "Blades Of Steel", "Millebournes", "Opetong", "Tile Rummy"};
        }
        protected override async Task ChooseAsync()
        {
            if (GameChosen == "Blades Of Steel")
                await Navigation!.PushAsync(new BladesOfSteelXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Millebournes")
                await Navigation!.PushAsync(new MillebournesXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Opetong")
                await Navigation!.PushAsync(new OpetongXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Tile Rummy")
                await Navigation!.PushAsync(new TileRummyXF.GamePage(Platform!, Starts!, Mode));
        }
    }
}