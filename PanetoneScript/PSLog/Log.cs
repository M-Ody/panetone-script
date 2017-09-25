namespace PanetoneScript.PSLog
{
    public class Log
    {
        LogList LogList;

        public Log(LogList logList)
        {
            LogList = logList;
        }

        public void PrintLog ()
        {
            foreach (Logable log in LogList)
            {
                log.Print();
            }
        }
    }
}
