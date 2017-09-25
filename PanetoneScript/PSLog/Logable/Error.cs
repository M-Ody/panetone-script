namespace PanetoneScript.PSLog
{
    public class Error : Logable
    {
        public Error(string message)
        {
            Message = "ERROR: " + message;
        }
    }
}
