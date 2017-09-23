namespace PanetoneScript
{
    public class ScriptFile
    {
        public string [] CodeLines { get; private set; }

        public ScriptFile(string [] codeLines)
        {
            CodeLines = codeLines;
        }
    }
}