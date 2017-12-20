using System.Collections.Generic;

namespace PanetoneScript.PanetoneScript
{
    public class StringsRepository
    {
        private List<string> repository;

        public StringsRepository()
        {
            repository = new List<string>();
        }

        public void Add(string str)
        {
            str = str.Replace("\\", "");
            repository.Add(str);
        }

        public int GetLength()
        {
            return repository.Count;
        }
    }
}
