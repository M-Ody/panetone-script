namespace PanetoneScript
{
    public class ScriptLine
    {
        public int LineNumber { get; private set; }
        public string LineCode { get; private set; }

        public ScriptLine(int lineNumber, string lineCode)
        {
            LineNumber = lineNumber;
            LineCode = lineCode;
        }
    }
}
