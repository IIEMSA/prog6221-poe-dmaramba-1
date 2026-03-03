using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBotSecurity
{
    internal class Greeting
    {
        public void GreatUser(string username, string message)
        {
            if (message.ToLower().Contains("hello") || message.ToLower().Contains("hi") || message.ToLower().Contains("hey"))
            {
                Console.WriteLine($"Hello, {username}! How can I assist you today?");
            }
            if (message.ToLower().Contains("how are you"))
            {
                Console.WriteLine($"I am doing well, thanks {username} for asking");
            }
            if (message.ToLower().Contains("purpose"))
            {
                Console.WriteLine($"I exist to assist you with your cybersecurity needs, {username}!");
            }
        }
    }
}
