// See https://aka.ms/new-console-template for more information
namespace ExtensionMethodDemo.Extensions
{
    public static class Extensions
    {


        public static void PrintToConsole(this string message)
        {

            Console.WriteLine(message);
        }
    }
}