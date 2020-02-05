using CommonBasicStandardLibraries.CollectionClasses;
using GameLoaderXF;
using System.Threading.Tasks;
using BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses;
using static BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses.GlobalScreenClass;
namespace MiscSpecializedCardGames
{
    public class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            if (ScreenUsed == EnumScreen.SmallPhone)
                GameList = new CustomBasicList<string>() { "Dutch Blitz", "Flinch", "Life Card Game", "Millebournes", "SkipBo", "Tee It Up", "Uno"};
            else
                GameList = new CustomBasicList<string>() { "Dutch Blitz", "Flinch", "Fluxx", "Hit The Deck", "Life Card Game", "Milk Run", "Millebournes", "Monopoly Card Game", "SkipBo", "Sorry Card Game", "Tee It Up", "Uno", "Yahtzee Hands Down"};
        }
        protected override async Task ChooseAsync()
        {
            if (GameChosen == "Dutch Blitz")
                await Navigation!.PushAsync(new DutchBlitzXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Flinch")
                await Navigation!.PushAsync(new FlinchXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Fluxx")
                await Navigation!.PushAsync(new FluxxXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Hit The Deck")
                await Navigation!.PushAsync(new HitTheDeckXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Life Card Game")
                await Navigation!.PushAsync(new LifeCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Milk Run")
                await Navigation!.PushAsync(new MilkRunXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Millebournes")
                await Navigation!.PushAsync(new MillebournesXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Monopoly Card Game")
                await Navigation!.PushAsync(new MonopolyCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "SkipBo")
                await Navigation!.PushAsync(new SkipboXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Sorry Card Game")
                await Navigation!.PushAsync(new SorryCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Tee It Up")
                await Navigation!.PushAsync(new TeeItUpXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Uno")
                await Navigation!.PushAsync(new UnoXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Yahtzee Hands Down")
                await Navigation!.PushAsync(new YahtzeeHandsDownXF.GamePage(Platform!, Starts!, Mode));
        }
    }
}