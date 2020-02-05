using CommonBasicStandardLibraries.CollectionClasses;
using GameLoaderXF;
using System.Threading.Tasks;
using BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses;
using static BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses.GlobalScreenClass;
namespace MiscGames
{
    public class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            if (ScreenUsed == EnumScreen.SmallPhone)
                GameList = new CustomBasicList<string>() { "Bingo", "Concentration", "Crazy Eights", "Dice Dominos", "Dominos (Regular)", "Italian Dominos", "Lotto Dominos", "Three Letter Fun"};
            else
                GameList = new CustomBasicList<string>() { "Battleship", "Bingo", "Blades Of Steel", "Concentration", "Crazy Eights", "Cribbage", "Dice Dominos", "Dominos (Regular)", "Go Fish", "Golf Card Game", "Italian Dominos", "Lotto Dominos", "Old Maid", "Racko", "Three Letter Fun"};
        }
        protected override async Task ChooseAsync()
        {
            if (GameChosen == "Battleship")
                await Navigation!.PushAsync(new BattleshipXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Bingo")
                await Navigation!.PushAsync(new BingoXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Blades Of Steel")
                await Navigation!.PushAsync(new BladesOfSteelXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Concentration")
                await Navigation!.PushAsync(new ConcentrationXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Crazy Eights")
                await Navigation!.PushAsync(new CrazyEightsXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Cribbage")
                await Navigation!.PushAsync(new CribbageXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Dice Dominos")
                await Navigation!.PushAsync(new DiceDominosXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Dominos (Mexican Train)")
                await Navigation!.PushAsync(new DominosMexicanTrainXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Dominos (Regular)")
                await Navigation!.PushAsync(new DominosRegularXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Go Fish")
                await Navigation!.PushAsync(new GoFishXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Golf Card Game")
                await Navigation!.PushAsync(new GolfCardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Italian Dominos")
                await Navigation!.PushAsync(new ItalianDominosXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Lotto Dominos")
                await Navigation!.PushAsync(new LottoDominosXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Old Maid")
                await Navigation!.PushAsync(new OldMaidXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Racko")
                await Navigation!.PushAsync(new RackoXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Three Letter Fun")
                await Navigation!.PushAsync(new ThreeLetterFunXF.GamePage(Platform!, Starts!, Mode));
        }
    }
}