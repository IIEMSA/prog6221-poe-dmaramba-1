using CyberBotSecurity;

Console.WriteLine("Welcome to CyberBot Security!");
ImageLoader imageLoader = new ImageLoader();
imageLoader.Show();
Console.Write("Please enter your name:");
var userName = Console.ReadLine();
Console.WriteLine($"Hello, {userName}! Let's get started with securing your cyber environment.");

var chatbot = new ChatbotLogic();
var userMessage = "";


while (userMessage != "exit")
{
    Console.WriteLine();
    Console.Write($"{userName} (type 'exit' to quit):");
    userMessage = Console.ReadLine();
    if (userMessage!.Equals("exit", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Thank you for using CyberBot Security. Goodbye!");
        break;
    }
    chatbot.ProcessMessage(userName!, userMessage);
}

Console.ReadKey();