using PanetoneScript;
using System.Collections.Generic;
using System.IO;

namespace ScriptsLoader
{
    public static class ScriptsReader
    {
        public static ScriptFile[] ReadAll(string directory, List<string> filesNames)
        {
            var scriptsFiles = new List<ScriptFile>();
            foreach (string filename in filesNames)
            {
                string[] lines = File.ReadAllLines(directory + "\\" + filename);
                var scriptLines = new ScriptLine[lines.Length];

                for (int i = 0; i < lines.Length; i++)
                {
                    scriptLines[i] = new ScriptLine((i + 1), lines[i]);
                }

                var scriptFile = new ScriptFile(scriptLines, filename);
                scriptsFiles.Add(scriptFile);
            }
            return scriptsFiles.ToArray();
        }
    }
}