using PanetoneScript.PanetoneScript;
using ScriptsLoader;
using System;

namespace PanetoneScript
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = @"C:\Users\mathias.ody\Documents\Mathias Ody\Ps\testeComp";
            string filename;

            filename = Console.ReadLine();

            Console.WriteLine(directory + filename);

            ScriptsLoader.ScriptsLoader.LoadFolderFiles(directory);

            ScriptFile[] scriptFiles = ScriptsReader.ReadAll(directory, ScriptsLoader.ScriptsLoader.GetAllFilesNames());

            var preProcessor = new PreProcessor.PreProcessor();
            StringsRepository stringsRepo = new StringsRepository();

            preProcessor.Execute(ref scriptFiles, ref stringsRepo);


            Console.ReadLine();
        }
    }
}
