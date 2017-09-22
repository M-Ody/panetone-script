using ScritsLoader.Utils;
using System.Collections.Generic;
using System.IO;

namespace ScritsLoader
{
    public static class ScriptsLoader
    {
        private static string filesDir;
        private static List<string> panetoneFilesNames = new List<string>();

        public static void LoadFolder (string directory)
        {
            if (Directory.Exists(directory))
            {
                filesDir = directory;
                CheckPanetoneFilesOnFolder(directory);
            }
            else
            {
                Debug.LogError("O diretório especificado não existe");
            }
        }

        private static void CheckPanetoneFilesOnFolder(string directory)
        {
            var nonPanetoneFiles = new List<string>();

            DirectoryInfo dir = new DirectoryInfo(directory);
            foreach (FileInfo file in dir.EnumerateFiles())
            {
                if (file.Extension == ".panetone")
                {
                    panetoneFilesNames.Add(file.Name);
                }
                else
                {
                    nonPanetoneFiles.Add(file.Name);
                }
            }

            if (nonPanetoneFiles.Count > 0)
            {
                foreach (string nonPanetone in nonPanetoneFiles)
                {
                    Debug.LogWarning(@"Existem arquivos na pasta designada que não são de uma extensão aceita (.panetone): " + nonPanetone);
                }
            }
        }

        private static void Open ()
        {
        }
    }
}
