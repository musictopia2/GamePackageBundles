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
using GameLoaderXF;
using BasicGameFramework.CommonInterfaces;
using BasicGameFramework.StandardImplementations.XamarinForms.Interfaces;
//i think this is the most common things i like to do
namespace RareSoloGames
{
    public class StartPage : BasicLoaderPage<BasicViewModel>
    {
        public StartPage(IGamePlatform platform, IStartUp starts, IForceOrientation forces, IScreen screen, bool multiPlayer) : base(platform, starts, forces, screen, multiPlayer) { }
    }
}
