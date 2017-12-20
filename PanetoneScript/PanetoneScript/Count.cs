namespace PanetoneScript.PanetoneScript
{
    public static class Count
    {
        public static int OnString(string source, char toCount)
        {
            int count = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == toCount) count++;
            }
            return count;
        }
    }
}
