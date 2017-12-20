using PanetoneScript.PanetoneScript;
using PanetoneScript.PreProcessor.Modules;
using PanetoneScript.PSLog;
using System.Collections.Generic;

namespace PanetoneScript.PreProcessor
{
    public class PreProcessor
    {
        //
        // Initialize PreProcessor
        //
        private List<PreProcessorDirective> directives;
        private CheckForPreProcessorDirectives checker;
        //private CodeCleaner codeCleaner;
        private RemoveStrings removeStrings;

        public PreProcessor()
        {
            directives = new List<PreProcessorDirective>();
            checker = new CheckForPreProcessorDirectives();
            removeStrings = new RemoveStrings();
            //codeCleaner = new CodeCleaner();
        }

        //
        // Execute all steps
        //
        public void Execute(ref ScriptFile[] scriptFiles, ref StringsRepository stringsRepo)
        {
            // Init
            LogList logList = new LogList();
            Log log = new Log(logList);

            // Execute
            try
            {
                checker.Process(ref scriptFiles, ref log, ref directives);
                removeStrings.Process(ref scriptFiles, ref log, ref stringsRepo);
                //TODO: Execute block and sigle action directives

            }
            catch (System.Exception ex)
            {
                //throw new System.Exception(ex.Message);
            }
            finally
            {
                log.PrintLog();
            }
        }
    }
}
