using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OpenAI.Extensions;
using OpenAI.GenerateCartoonApp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddOpenAIService(opt => opt.ApiKey = "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");

await builder.Build().RunAsync();
