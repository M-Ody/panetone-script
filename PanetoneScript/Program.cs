using System;

namespace PanetoneScript
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = @"C:\Users\0176416\Documents\Ps";
            string filename;

            filename = Console.ReadLine();

            Console.WriteLine(directory + filename);

            ScriptsLoader.ScriptsLoader.LoadFolderFiles(directory);

            ScriptsLoader.ScriptsReader.ReadAll(directory,ScriptsLoader.ScriptsLoader.GetAllFilesNames());

            Console.ReadLine();
        }
    }
}
