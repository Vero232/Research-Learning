// See https://aka.ms/new-console-template for more information

namespace ExtensionMethodDemo
{
    public static class ExtendSimppleLogger
    {
        public static void LogError(this ISimpleLogger logger, string message)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            logger.Log(message, "Error");
            Console.ForegroundColor=defaultColor;
        }

        public static void LogWarning(this ISimpleLogger logger, string message)
        {
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            logger.Log(message, "Warning");
            Console.ForegroundColor = defaultColor;
        }

    }
}