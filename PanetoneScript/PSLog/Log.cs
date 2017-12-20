namespace PanetoneScript.PSLog
{
    public class Log
    {
        private LogList LogList;

        public Log(LogList logList)
        {
            LogList = logList;
        }

        public void Error(string str)
        {
            LogList.Add(new Error(str));
            throw new System.Exception("Ocorreu um erro. Cheque o Log para mais informações");
        }

        public void Warning(string str)
        {
            LogList.Add(new Warning(str));
        }

        public void Message(string str)
        {
            LogList.Add(new Message(str));
        }

        public void PrintLog()
        {
            foreach (Logable log in LogList)
            {
                log.Print();
            }
        }
    }
}
