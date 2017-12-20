using ScriptsLoader.Utils;

namespace PanetoneScript.PSLog
{
    public class Logable
    {
        protected string Message;

        public virtual void Print()
        {
            Debug.Log(Message);
        }
    }
}
