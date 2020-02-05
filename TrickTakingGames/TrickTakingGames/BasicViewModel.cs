using CommonBasicStandardLibraries.CollectionClasses;
using GameLoaderXF;
using System.Threading.Tasks;
using BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses;
using static BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses.GlobalScreenClass;
namespace TrickTakingGames
{
    public class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            if (ScreenUsed == EnumScreen.SmallPhone)
                GameList = new CustomBasicList<string>() { "California Jack", "German Whist"};
            else
                GameList = new CustomBasicList<string>() { "California Jack", "Galaxy Card Game", "German Whist", "Horseshoe", "Huse Hearts", "Pickel Card Game", "Pinochle (2 Player)", "Rage Card Game", "Rook", "Rounds Card Game", "Sixty Six (2 Player)", "Skuck Card Game", "Snag Card Game", "Spades (2 Player)", "Xactika"};
        }
        protected override async Task ChooseAsync()
        {
            if (GameChosen == "California Jack")
                await Navigation!.PushAsync(new CaliforniaJackXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Galaxy Card Game")
                await Navigation!.PushAsync(new GalaxyCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "German Whist")
                await Navigation!.PushAsync(new GermanWhistXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Horseshoe")
                await Navigation!.PushAsync(new HorseshoeCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Huse Hearts")
                await Navigation!.PushAsync(new HuseHeartsXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Pickel Card Game")
                await Navigation!.PushAsync(new PickelCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Pinochle (2 Player)")
                await Navigation!.PushAsync(new Pinochle2PlayerXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Rage Card Game")
                await Navigation!.PushAsync(new RageCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Rook")
                await Navigation!.PushAsync(new RookXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Rounds Card Game")
                await Navigation!.PushAsync(new RoundsCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Sixty Six (2 Player)")
                await Navigation!.PushAsync(new SixtySix2PlayerXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Skuck Card Game")
                await Navigation!.PushAsync(new SkuckCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Snag Card Game")
                await Navigation!.PushAsync(new SnagCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Spades (2 Player)")
                await Navigation!.PushAsync(new Spades2PlayerXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Xactika")
                await Navigation!.PushAsync(new XactikaXF.GamePage(Platform!, Starts!, Mode));
        }
    }
}