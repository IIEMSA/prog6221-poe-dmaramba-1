using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBotSecurity
{
    internal class ChatbotLogic
    {
        public void ProcessMessage(string username, string message)
        {
            if (message.Contains("hello", StringComparison.OrdinalIgnoreCase)
                 || message.Contains("how are you", StringComparison.OrdinalIgnoreCase) || message.Contains("purpose", StringComparison.OrdinalIgnoreCase))
            {
                Greeting greeting = new Greeting();
                greeting.GreatUser(username, message);
            }
            else
            {
                Console.WriteLine($"Sorry, I am not able to process your request, please rephrase.");
            }

        }
    }
}
