namespace PanetoneScript.Log
{
    public class Error : Logable
    {
        public Error(string message)
        {
            Message = "ERROR: " + message;
        }
    }
}
