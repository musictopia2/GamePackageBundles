var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.RegisterBlazorBeginningClasses();
builder.RootComponents.Add<aa2>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
bb1.OS = bb1.EnumOS.Wasm;
ss1.IsWasm = true;
aa2.AppStyleName = "AllMultiplayerGames.WebAssembly";
aa2.AdditionalAssembly = typeof(LoaderViewModel).Assembly;
//start
GlobalClass.Version = "11.2";
//end
LoaderGlobalClass.LoadSettingsAsync = GlobalSettingsExtensions.LoadGlobalDataAsync;
LoaderGlobalClass.SaveSettingsAsync = GlobalSettingsExtensions.SaveGlobalDataAsync;

MultiplayerGamesBlazorLoaderLibrary.HostedServerConfiguration.DefaultServerUrl = "https://gamepackagerestrictedhostserver-latest.onrender.com";


aa1.Register(); //i think this is needed now so it can properly serialize the 2 items.
builder.Services.RegisterDefaultMultiplayerProcesses<BasicViewModel>();
builder.Services.RegisterSignalRGameDiscoveryServices();
await builder.Build().RunAsync();
//note:  if i ever needed automation here, then will need to edit 2 files.