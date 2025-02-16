using LLMs;
using LLMs.ConstvsReadOnly;
using LLMs.DelegatesAndEvents;
using LLMs.DependencyInversion.GoodCode;
using LLMs.InterfaceSegregation.GoodCode;
using LLMs.LiskovSubstitution.GoodCode;
using LLMs.OpenAndClosedPrinciple;
using LLMs.OpenAndClosedPrinciple.GoodCode;
using LLMs.SingleResponsibility;
using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics.Metrics;

var builder = Host.CreateApplicationBuilder();
ConstVsReadOnly constVsReadOnly = new ConstVsReadOnly("test");

var num = 0;
var eric = "eric test";
num.ToString();
eric.ToString(num);

#region Events
var video = new Video { Title = "video 1" };
var videoEncoder = new VideoEncoder(); //publisher
var mailService = new MailService(); // Subscriber
var message = new MessageService(); // Subscriber

videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
videoEncoder.VideoEncoded += message.OnVideoEncoded;
videoEncoder.Encode(video);
#endregion


#region Lambda Expression
/// Lambda Expression = arg => expression
/// no argument: () => ...
/// single argument: x => ...
/// (x, y. z) => ...
Func<int, int> square = number => number * number;
Console.WriteLine(square(5));

const int factor = 5;
Func<int, int> multiplier = number => number * factor;
Console.WriteLine(multiplier(10));
#endregion


#region Delegates Implementation
var photoProcessor = new PhotoProcessor();
    var filters = new PhotoFilters();
    var photo = filters.ApplyBrightness;
    photo += filters.ApplyContrast;
    // Action returns void
    // Func return a type of Tresult
    photoProcessor.Process("TestPhoto.jpg", photo);
#endregion

#region Single Responsibility Principle
/// <summary>
/// A class should have only one reason to change i.e This means that each class should have just one job. If a class is responsible for multiple things, it becomes harder to maintain, test, and extend.
/// </summary>
IReportService service = new ReportService();
service.ProcessReport();
#endregion

#region Open and close priciple
/// <summary>
/// An class should be open for extension but closed for modification
/// </summary>
IDiscountStrategy discount = new SuperVIPDiscount();
DiscountCalculator calculator = new DiscountCalculator(discount);
var finalAmount = calculator.CalculateDiscount(1000);
#endregion

#region Liskov Substitution Principle (LSP)
/// <summary>
/// "If a class (child) is a subclass of another class (parent), it should be able to replace the parent without breaking the program."
/// ✅ A subclass should be able to do everything its parent class can do—without changing expected behavior.
/// ✅ If a child class needs to override or remove a behavior, it's probably violating LSP
/// </summary>
FlyingBird sparrow = new Sparrow();
sparrow.Fly(); // Works fine

Bird penguin = new Penguin();
penguin.MakeSound(); // Works fine
#endregion

 #region Interface Segregation Principle (ISP)
/// <summary>
/// "A class should not be forced to implement methods it does not use."
/// ✅ Each class only implements what it needs.
/// ✅ No unused methods → No more throw new NotImplementedException().
/// ✅ Easier to extend → If we need a new device that only scans, we simply implement IScanner.
/// </summary>
MultiFunctionPrinter multiFunctionPrinter = new();
BasicPrinter basicPrinter = new();

#endregion

#region Dependency Inversion Principle (DIP) 
/// <summary>
/// "High-level modules should not depend on low-level modules. Both should depend on abstractions (interfaces)."
/// ✅ Don’t make classes directly depend on other concrete classes.
/// ✅ Instead, depend on interfaces or abstract classes, so that we can easily swap out implementations.
/// ✅ High-level module (Switch) depends on an abstraction (IDevice) instead of a concrete class.
/// ✅ Easier to extend → We can add new devices(e.g., SmartBulb, Heater) without modifying Switch.
/// ✅ Easier to test → We can replace IDevice with a mock during unit testing.
/// ✅ Follows Dependency Inversion Principle (DIP) → Both high-level (Switch) and low-level
/// </summary>
IDevice bulb = new LightBulb(); // We can easily swap this with a Fan
Switch lightSwitch = new Switch(bulb);
lightSwitch.Operate(true);  // Light is ON
lightSwitch.Operate(false); // Light is OFF

IDevice fan = new Fan(); // Now using a fan instead of a bulb
Switch fanSwitch = new Switch(fan);
fanSwitch.Operate(true);  // Fan is ON
fanSwitch.Operate(false); // Fan is OFF

#endregion

#region LLms
builder.Services.AddChatClient(new OllamaChatClient(new Uri("http://localhost:11434"), "llama3"));

var app = builder.Build();

var chatClient = app.Services.GetRequiredService<IChatClient>();

//var chatCompletion = await chatClient.CompleteAsync("What is .NET? Reply in 50 words max.");

//Console.WriteLine(chatCompletion.Message.Text);

var chatHistory = new List<ChatMessage>();

while (true)
{
    Console.WriteLine("Enter your prompt:");
    var userPrompt = Console.ReadLine();
    chatHistory.Add(new ChatMessage(ChatRole.User, userPrompt));

    Console.WriteLine("Response from AI:");
    var chatResponse = "";
    await foreach (var item in chatClient.CompleteStreamingAsync(chatHistory))
    {
        // We're streaming the response, so we get each message as it arrives
        Console.Write(item.Text);
        chatResponse += item.Text;
    }
    chatHistory.Add(new ChatMessage(ChatRole.Assistant, chatResponse));
    Console.WriteLine();
}

//var posts = Directory.GetFiles("posts").Take(5).ToArray();
//foreach (var post in posts)
//{
//    string prompt = $$"""
//         You will receive an input text and the desired output format.
//         You need to analyze the text and produce the desired output format.
//         You not allow to change code, text, or other references.

//         # Desired response

//         Only provide a RFC8259 compliant JSON response following this format without deviation.

//         {
//            "title": "Title pulled from the front matter section",
//            "summary": "Summarize the article in no more than 100 words"
//         }

//         # Article content:

//         {{File.ReadAllText(post)}}
//         """;

//    var chatCompletion = await chatClient.CompleteAsync(prompt);
//    Console.WriteLine(chatCompletion.Message.Text);
//    Console.WriteLine(Environment.NewLine);
//}

// 
#endregion