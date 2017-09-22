using System;

namespace ScritsLoader.Utils
{
    public class Debug
    {
        public static void LogError(string message)
        {
            Console.WriteLine("ERRO: " + message);
        }

        public static void Log(string message)
        {
            Console.WriteLine(message);
        }

        public static void LogWarning(string message)
        {
            Console.WriteLine("WARNING: " + message);
        }
    }
}
