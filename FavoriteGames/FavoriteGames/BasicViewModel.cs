using CommonBasicStandardLibraries.CollectionClasses;
using GameLoaderXF;
using System.Threading.Tasks;
using BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses;
using static BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses.GlobalScreenClass;
namespace FavoriteGames
{
    public class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            if (ScreenUsed == EnumScreen.SmallPhone)
                GameList = new CustomBasicList<string>() { "Aggravation", "Fill Or Bust", "German Whist", "Kismet", "Millebournes", "SkipBo", "Tee It Up", "Think Twice", "Trouble", "Uno"};
            else
                GameList = new CustomBasicList<string>() { "8 Round Rummy", "Aggravation", "Blades Of Steel", "Cousin Rummy", "Fill Or Bust", "Five Crowns", "German Whist", "Hit The Deck", "Huse Hearts", "Kismet", "Life Board Game", "Millebournes", "Payday", "Phase 10", "Pickel Card Game", "Rage Card Game", "Rummy 500", "Rummy Dice", "SkipBo", "Skuck Card Game", "Sorry Card Game", "Sorry", "Spades (2 Player)", "Tee It Up", "Think Twice", "Trouble", "Uno", "Xactika"};
        }
        protected override async Task ChooseAsync()
        {
            if (GameChosen == "8 Round Rummy")
                await Navigation!.PushAsync(new A8RoundRummyXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Aggravation")
                await Navigation!.PushAsync(new AggravationXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Blades Of Steel")
                await Navigation!.PushAsync(new BladesOfSteelXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Cousin Rummy")
                await Navigation!.PushAsync(new CousinRummyXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Fill Or Bust")
                await Navigation!.PushAsync(new FillOrBustXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Five Crowns")
                await Navigation!.PushAsync(new FiveCrownsXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "German Whist")
                await Navigation!.PushAsync(new GermanWhistXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Hit The Deck")
                await Navigation!.PushAsync(new HitTheDeckXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Huse Hearts")
                await Navigation!.PushAsync(new HuseHeartsXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Kismet")
                await Navigation!.PushAsync(new KismetXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Life Board Game")
                await Navigation!.PushAsync(new LifeBoardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Millebournes")
                await Navigation!.PushAsync(new MillebournesXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Payday")
                await Navigation!.PushAsync(new PaydayXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Phase 10")
                await Navigation!.PushAsync(new Phase10XF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Pickel Card Game")
                await Navigation!.PushAsync(new PickelCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Rage Card Game")
                await Navigation!.PushAsync(new RageCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Rummy 500")
                await Navigation!.PushAsync(new Rummy500XF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Rummy Dice")
                await Navigation!.PushAsync(new RummyDiceXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "SkipBo")
                await Navigation!.PushAsync(new SkipboXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Skuck Card Game")
                await Navigation!.PushAsync(new SkuckCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Sorry Card Game")
                await Navigation!.PushAsync(new SorryCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Sorry")
                await Navigation!.PushAsync(new SorryXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Spades (2 Player)")
                await Navigation!.PushAsync(new Spades2PlayerXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Tee It Up")
                await Navigation!.PushAsync(new TeeItUpXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Think Twice")
                await Navigation!.PushAsync(new ThinkTwiceXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Trouble")
                await Navigation!.PushAsync(new TroubleXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Uno")
                await Navigation!.PushAsync(new UnoXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Xactika")
                await Navigation!.PushAsync(new XactikaXF.GamePage(Platform!, Starts!, Mode));
        }
    }
}