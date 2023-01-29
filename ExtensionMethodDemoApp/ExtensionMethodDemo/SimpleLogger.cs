// See https://aka.ms/new-console-template for more information

namespace ExtensionMethodDemo
{
    public class SimpleLogger : ISimpleLogger
    {

        public void Log(string message)
        {

            Console.WriteLine(message);

        }

        public void Log(string message, string messageType)
        {

            Console.WriteLine($"{messageType}: {message}");
        }
    }
}