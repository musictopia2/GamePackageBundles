using System;
using System.Text;
using CommonBasicStandardLibraries.Exceptions;
using CommonBasicStandardLibraries.AdvancedGeneralFunctionsAndProcesses.BasicExtensions;
using System.Linq;
using CommonBasicStandardLibraries.BasicDataSettingsAndProcesses;
using static CommonBasicStandardLibraries.BasicDataSettingsAndProcesses.BasicDataFunctions;
using CommonBasicStandardLibraries.CollectionClasses;
using System.Threading.Tasks; //most of the time, i will be using asyncs.
using fs = CommonBasicStandardLibraries.AdvancedGeneralFunctionsAndProcesses.JsonSerializers.FileHelpers;
using js = CommonBasicStandardLibraries.AdvancedGeneralFunctionsAndProcesses.JsonSerializers.NewtonJsonStrings; //just in case i need those 2.
using Xamarin.Forms;
using BasicGameFramework.StandardImplementations.XamarinForms.Interfaces;
using GameLoaderXF;
using BasicGameFramework.CommonInterfaces;
using GamePackageSignalRClasses;
//i think this is the most common things i like to do
namespace MiscGames
{
    public class App : Application
    {
        public App(IGamePlatform platform, IForceOrientation forces, IScreen screen)
        {
            IStartUp starts = new MainStartUp();
            MainPage = new NavigationPage(new StartPage(platform, starts, forces, screen, true));
        }
    }
}