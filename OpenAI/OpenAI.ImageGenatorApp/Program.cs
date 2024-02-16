using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OpenAI.ImageGenatorApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddOpenAIServices(opt => opt.ApiKey = "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");

await builder.Build().RunAsync();
