using System;
using System.Collections.Generic;

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

            List<ScriptFile> scriptFiles = ScriptsLoader.ScriptsReader.ReadAll(directory,ScriptsLoader.ScriptsLoader.GetAllFilesNames());

            Console.ReadLine();
        }
    }
}
