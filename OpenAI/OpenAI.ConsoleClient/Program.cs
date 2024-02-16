using OpenAI.Managers;
using OpenAI;
using OpenAI.ObjectModels.RequestModels;
using OpenAI.ObjectModels;


var openAiService = new OpenAIService(new OpenAiOptions()
{
    ApiKey = "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"
});



while (true)
{
    Console.WriteLine("Please enter your prompt.");

    var usersPrompt = Console.ReadLine();

    /*
    --------------- CHATGPT Example ---------------

    var completionResult = await openAiService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
    {
        Messages = new List<ChatMessage>
    {
        ChatMessage.FromUser(usersPrompt)
    },
        Model = Models.Gpt_3_5_Turbo,
        MaxTokens = 500//optional
    });

    if (completionResult.Successful)
    {
        Console.WriteLine(completionResult.Choices.First().Message.Content);
    }
    */


    // DALL-E use to create image.
    var imageResult = await openAiService.Image.CreateImage(new ImageCreateRequest
    {
        Prompt = usersPrompt,
        N = 2,
        Size = StaticValues.ImageStatics.Size.Size256,
        ResponseFormat = StaticValues.ImageStatics.ResponseFormat.Url,
        User = "TestUser"
    });


    if (imageResult.Successful)
    {
        Console.WriteLine(string.Join("\n", imageResult.Results.Select(r => r.Url)));
    }

    Console.ReadLine();
}


