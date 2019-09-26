using CommonBasicStandardLibraries.CollectionClasses;
using GameLoaderXF;
using System.Threading.Tasks;
using BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses;
using static BasicGameFramework.StandardImplementations.CrossPlatform.DataClasses.GlobalScreenClass;
namespace NonCardOrSolitaireGames
{
    public class BasicViewModel : LoaderViewModel
    {
        protected override void GenerateGameList()
        {
            if (ScreenUsed == EnumScreen.SmallPhone)
                GameList = new CustomBasicList<string>() { "Blackjack", "Bunco Dice Game", "Froggies", "Mastermind", "Minesweeper", "Poker", "Solitaire Board Game", "XPuzzle"};
            else
                GameList = new CustomBasicList<string>() { "Blackjack", "Bunco Dice Game", "Froggies", "Mastermind", "Minesweeper", "Poker", "Solitaire Board Game", "XPuzzle"};
        }
        protected override async Task ChooseAsync()
        {
            if (GameChosen == "Blackjack")
                await Navigation!.PushAsync(new BlackjackXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Bunco Dice Game")
                await Navigation!.PushAsync(new BuncoDiceGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Froggies")
                await Navigation!.PushAsync(new FroggiesXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Mastermind")
                await Navigation!.PushAsync(new MastermindXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Minesweeper")
                await Navigation!.PushAsync(new MinesweeperXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Poker")
                await Navigation!.PushAsync(new PokerXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "Solitaire Board Game")
                await Navigation!.PushAsync(new SolitaireBoardGameXF.GamePage(Platform!, Starts!, Mode));
            if (GameChosen == "XPuzzle")
                await Navigation!.PushAsync(new XPuzzleXF.GamePage(Platform!, Starts!, Mode));
        }
    }
}