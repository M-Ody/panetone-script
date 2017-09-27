using System;

namespace PanetoneScript.PreProcessor
{
	public class PreProcessorDirective
	{
		public int LineNumber { get; private set; }
		public string Directive { get; private set; }

		public PreProcessorDirective (int lineNumber, string directive)
		{
			LineNumber = lineNumber;
			Directive = directive;
		}
	}
}

