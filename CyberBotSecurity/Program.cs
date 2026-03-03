using CyberBotSecurity;

Console.WriteLine("Welcome to CyberBot Security!");
Console.Write("Please enter your name:");
var userName = Console.ReadLine();
Console.WriteLine($"Hello, {userName}! Let's get started with securing your cyber environment.");

var chatbot = new ChatbotLogic();
var userMessage = "";

//do
//{
//    Console.WriteLine("Please enter your message (type 'exit' to quit):");
//    userMessage = Console.ReadLine();
//    chatbot.ProcessMessage(userName, userMessage);
//} while (!userMessage.Equals("exit", StringComparison.OrdinalIgnoreCase));
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