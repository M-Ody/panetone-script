using System.Collections.Generic;

namespace PanetoneScript.PanetoneScript
{
    public class StringStorage
    {
        public List<string> storedStrings { get; private set; }

        public StringStorage()
        {
            storedStrings = new List<string>();
        }

        public void Add(string str)
        {
            storedStrings.Add(str);
        }
    }
}
