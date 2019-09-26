using CommonBasicStandardLibraries.CollectionClasses;
using GameLoaderXF;
using System.Threading.Tasks;
using BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses;
using static BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses.GlobalScreenClass;
namespace CristinaFavoriteSoloGames
{
    public class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            if (ScreenUsed == EnumScreen.SmallPhone)
                GameList = new CustomBasicList<string>() { "Blackjack", "Carpet Solitaire", "Easy Go Solitaire", "Froggies", "Klondike Solitaire", "Mastermind", "Spider Solitaire"};
            else
                GameList = new CustomBasicList<string>() { "Blackjack", "Clock Solitaire", "Carpet Solitaire", "Easy Go Solitaire", "Froggies", "Klondike Solitaire", "MahJong Solitaire", "Mastermind", "Spider Solitaire"};
        }
        protected override async Task ChooseAsync()
        {
            if (GameChosen == "Blackjack")
                await Navigation!.PushAsync(new BlackjackXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Clock Solitaire")
                await Navigation!.PushAsync(new ClockSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Carpet Solitaire")
                await Navigation!.PushAsync(new CarpetSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Easy Go Solitaire")
                await Navigation!.PushAsync(new EasyGoSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Froggies")
                await Navigation!.PushAsync(new FroggiesXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Klondike Solitaire")
                await Navigation!.PushAsync(new KlondikeSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "MahJong Solitaire")
                await Navigation!.PushAsync(new MahJongSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Mastermind")
                await Navigation!.PushAsync(new MastermindXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Spider Solitaire")
                await Navigation!.PushAsync(new SpiderSolitaireXF.GamePage(Platform!, Starts!, Mode));
        }
    }
}