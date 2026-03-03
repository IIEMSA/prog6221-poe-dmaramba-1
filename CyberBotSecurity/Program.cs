using CyberBotSecurity;

Console.WriteLine("Welcome to CyberBot Security!");
Console.WriteLine("Please enter your name:");
var userName = Console.ReadLine();
Console.WriteLine($"Hello, {userName}! Let's get started with securing your cyber environment.");

var chatbot = new ChatbotLogic();
var userMessage = "";

do
{
    Console.WriteLine("Please enter your message (type 'exit' to quit):");
    userMessage = Console.ReadLine();
    chatbot.ProcessMessage(userName, userMessage);
} while (!userMessage.Equals("exit", StringComparison.OrdinalIgnoreCase));

Console.ReadKey();