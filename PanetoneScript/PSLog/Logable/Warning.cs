using ScriptsLoader.Utils;

namespace PanetoneScript.PSLog
{
    public class Warning : Logable
    {
        public Warning(string message)
        {
            Message = message;
        }

        public override void Print()
        {
            Debug.LogWarning(Message);
        }
    }
}
