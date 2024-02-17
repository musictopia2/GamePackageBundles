var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.RegisterBlazorBeginningClasses();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
bb1.OS = bb1.EnumOS.Wasm;
ss1.IsWasm = true;
//start
GlobalClass.Version = "8.5";
//end
LoaderGlobalClass.LoadSettingsAsync = GlobalSettingsExtensions.LoadGlobalDataAsync;
LoaderGlobalClass.SaveSettingsAsync = GlobalSettingsExtensions.SaveGlobalDataAsync;
builder.Services.RegisterDefaultMultiplayerProcesses<BasicViewModel>();
await builder.Build().RunAsync();
