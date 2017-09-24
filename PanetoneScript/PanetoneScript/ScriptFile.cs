namespace PanetoneScript
{
    public class ScriptFile
    {
        public ScriptLine[] CodeLines { get; set; }
        public string Filename { get; private set; }

        public ScriptFile(ScriptLine[] codeLines, string filename)
        {
            CodeLines = codeLines;
            Filename = filename;
        }
    }
}
