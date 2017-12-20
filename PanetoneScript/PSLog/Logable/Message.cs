using ScriptsLoader.Utils;

namespace PanetoneScript.PSLog
{
    public class Message : Logable
    {
        public Message(string message)
        {
            Message = message;
        }

        public override void Print()
        {
            Debug.Log(Message);
        }
    }
}

