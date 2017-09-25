using System;
using PanetoneScript.PSLog;

namespace PanetoneScript.PreProcessor
{
    public class PreProcessor : ICompilationStep
    {
        public void Execute()
        {
			LogList logList = new LogList ();
			Log log = new Log (logList);
            try
            {
                //executar
            }
            catch
            {
                //print fatal error
            }
            finally
            {
				log.PrintLog ();
            }
        }
    }
}
