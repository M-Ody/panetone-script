using System;
using System.Collections.Generic;
using PanetoneScript.PSLog;

namespace PanetoneScript.PreProcessor.Modules
{
	public class CheckForPreProcessorDirectives
	{
		public void Process(ref ScriptFile scriptFile, ref LogList log, ref List<PreProcessorDirective> directives)
		{
			try 
			{
				FindPreProcessorDirectives (ref scriptFile, ref log, ref directives);
			}
			// À toda referência pega, adicionar nome do arquivo
			catch (Exception e)
			{
				throw new Exception (e.Message + " - " + scriptFile.Filename);
			}
		}

		private void FindPreProcessorDirectives (ref ScriptFile scriptFile, ref LogList log, ref List<PreProcessorDirective> directives) 
		{
			foreach (ScriptLine line in scriptFile.CodeLines) 
			{
				if (line.LineCode.Contains ("#")) 
				{
					string directive = line.LineCode.Substring (line.LineCode.IndexOf ("#") + 1);
					directives.Add (new PreProcessorDirective (line.LineNumber, directive));
				}
			}
		}
	}
}

