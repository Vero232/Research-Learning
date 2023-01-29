// See https://aka.ms/new-console-template for more information
using ExtensionMethodDemo.Extensions;

namespace ExtensionMethodDemo
{
    class Program
    {
        static void Main(string[] args) 
        {
            string demo = "This is a demo";

            demo.PrintToConsole();

            ISimpleLogger logger = new SimpleLogger();
 
            logger.LogError("This is an error");
            logger.LogWarning("This is an warning");
        }
    }
}