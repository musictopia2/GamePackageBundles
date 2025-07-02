var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.RegisterBlazorBeginningClasses();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
bb1.OS = bb1.EnumOS.Wasm;
ss1.IsWasm = true;
aa2.AppStyleName = "AllMultiplayerGames.WebAssembly";
aa2.AdditionalAssembly = typeof(LoaderViewModel).Assembly;
//start
GlobalClass.Version = "9.30";
//end
LoaderGlobalClass.LoadSettingsAsync = GlobalSettingsExtensions.LoadGlobalDataAsync;
LoaderGlobalClass.SaveSettingsAsync = GlobalSettingsExtensions.SaveGlobalDataAsync;
aa1.Register(); //i think this is needed now so it can properly serialize the 2 items.
builder.Services.RegisterDefaultMultiplayerProcesses<BasicViewModel>();
await builder.Build().RunAsync();
//note:  if i ever needed automation here, then will need to edit 2 files.