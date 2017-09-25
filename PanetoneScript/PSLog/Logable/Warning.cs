namespace PanetoneScript.PSLog
{
    public class Warning : Logable
    {
        public Warning(string message)
        {
            Message = "WARNING: " + message;
        }
    }
}
