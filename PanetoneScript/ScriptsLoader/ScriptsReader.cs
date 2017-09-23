using PanetoneScript;
using ScriptsLoader.Utils;
using System.Collections.Generic;
using System.IO;

namespace ScriptsLoader
{
    public static class ScriptsReader
    {
        public static List<ScriptFile> ReadAll (string directory, List<string> filesNames)
        {
            var scriptsFiles = new List<ScriptFile>();
            foreach (string filename in filesNames)
            {
                var scriptFile = new ScriptFile(File.ReadAllLines(directory + "\\" + filename));
                scriptsFiles.Add(scriptFile);
            }
            return scriptsFiles;
        }
    }
}