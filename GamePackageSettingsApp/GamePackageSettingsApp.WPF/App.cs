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
using System.Windows;
namespace GamePackageSettingsApp.WPF
{
    public sealed partial class App : Application
    {
        static App()
        { }

        public App()
        { }

        protected override void OnStartup(StartupEventArgs e)
        {
            //this means i could decide to not even override but instead go directly to another class to do the work.  that is very good to know.
            MainWindow = new NewWindow(); //hopefully that is it this time.
        }

        [STAThread]
        public static int Main()
        {
            App app = new App();
            app.Run();
            return 0;
        }
    }
}
