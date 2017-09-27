using System;
using PanetoneScript.PSLog;

namespace PanetoneScript.PreProcessor.Modules
{
    public class InitialPreprocessorCheck
    {
		public void Process(ref ScriptFile scriptFile, ref LogList log)
        {
			try {
				FindPreProcessorDirectives (ref scriptFile, ref log);
			}
			// À toda referência pega, adicionar nome do arquivo
			catch (Exception e){
				throw new Exception (e.Message + " - " + scriptFile.Filename);
			}
        }

		private void FindPreProcessorDirectives (ref ScriptFile scriptFile, ref LogList log) 
		{
			foreach (ScriptLine line in scriptFile.CodeLines) 
			{
				if (line.LineCode.Contains ("#")) 
				{
					CheckOnlyOnePreProcessorDirective (line);
				}
			}
		}

		private void CheckOnlyOnePreProcessorDirective (ScriptLine line) 
		{
			// Checar se existe mais de uma diretiva na linha
			if (line.LineCode.IndexOf("#") != line.LineCode.LastIndexOf("#"))
			{
				throw new Exception (
					"Existe mais de uma diretiva de pre-processamento por linha (linha " + line.LineNumber + ")");
			}
		}
    }
}
