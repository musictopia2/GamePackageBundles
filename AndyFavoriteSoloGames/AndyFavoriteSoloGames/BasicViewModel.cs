using CommonBasicStandardLibraries.CollectionClasses;
using GameLoaderXF;
using System.Threading.Tasks;
using BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses;
using static BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses.GlobalScreenClass;
namespace AndyFavoriteSoloGames
{
    public class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            if (ScreenUsed == EnumScreen.SmallPhone)
                GameList = new CustomBasicList<string>() { "Klondike Solitaire", "Bisley Solitaire", "Florentine Solitaire", "Free Cell Solitaire", "Bakers Dozen Solitaire", "Beleagured Castle", "Eight Off Solitaire", "Spider Solitaire", "Martha Solitaire", "Persian Solitaire", "Pyramid Solitaire"};
            else
                GameList = new CustomBasicList<string>() { "MahJong Solitaire", "Klondike Solitaire", "Bisley Solitaire", "Florentine Solitaire", "Free Cell Solitaire", "Bakers Dozen Solitaire", "Beleagured Castle", "Eight Off Solitaire", "Spider Solitaire", "Martha Solitaire", "Persian Solitaire", "Grandfather's Clock", "Pyramid Solitaire"};
        }
        protected override async Task ChooseAsync()
        {
            if (GameChosen == "MahJong Solitaire")
                await Navigation!.PushAsync(new MahJongSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Klondike Solitaire")
                await Navigation!.PushAsync(new KlondikeSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Bisley Solitaire")
                await Navigation!.PushAsync(new BisleySolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Florentine Solitaire")
                await Navigation!.PushAsync(new FlorentineSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Free Cell Solitaire")
                await Navigation!.PushAsync(new FreeCellSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Bakers Dozen Solitaire")
                await Navigation!.PushAsync(new BakersDozenSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Beleagured Castle")
                await Navigation!.PushAsync(new BeleaguredCastleXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Eight Off Solitaire")
                await Navigation!.PushAsync(new EightOffSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Spider Solitaire")
                await Navigation!.PushAsync(new SpiderSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Martha Solitaire")
                await Navigation!.PushAsync(new MarthaSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Persian Solitaire")
                await Navigation!.PushAsync(new PersianSolitaireXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Grandfather's Clock")
                await Navigation!.PushAsync(new GrandfathersClockXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Pyramid Solitaire")
                await Navigation!.PushAsync(new PyramidSolitaireXF.GamePage(Platform!, Starts!, Mode));
        }
    }
}