using PanetoneScript.PSLog;
using System;
using System.Collections.Generic;

namespace PanetoneScript.PreProcessor.Modules
{
    public class CheckForPreProcessorDirectives
    {
        private string currentFile = string.Empty;

        public void Process(ref ScriptFile[] scriptFiles, ref Log log, ref List<PreProcessorDirective> directives)
        {
            for (int i = 0; i < scriptFiles.Length; i++)
            {
                currentFile = scriptFiles[i].Filename;
                FindPreProcessorDirectives(ref scriptFiles[i], ref log, ref directives);
            }
        }

        private void FindPreProcessorDirectives(ref ScriptFile scriptFile, ref Log log, ref List<PreProcessorDirective> directives)
        {
            #region CheckIfIsNull
            if (log == null) { throw new Exception("Erro interno: ref 'log' foi passado vazio em FindPreProcessorDirectives."); }
            if (scriptFile == null) { log.Error("Erro interno: ref 'scriptFile' foi passado vazio em FindPreProcessorDirectives."); }
            if (directives == null) { log.Error("Erro interno: ref 'directives' foi passado vazio em FindPreProcessorDirectives."); }
            #endregion

            foreach (ScriptLine line in scriptFile.CodeLines)
            {
                if (line.LineCode.Contains("#"))
                {
                    EnsureOnlyOnePreProcessorDirective(line, ref log);

                    string directive = line.LineCode.Substring(line.LineCode.IndexOf("#") + 1);
                    directives.Add(new PreProcessorDirective(line.LineNumber, directive));
                }
            }
        }

        private void EnsureOnlyOnePreProcessorDirective(ScriptLine line, ref Log log)
        {
            // Checar se existe mais de uma diretiva na linha
            if (line.LineCode.IndexOf("#") != line.LineCode.LastIndexOf("#"))
            {
                log.Error("Existe mais de uma diretiva de pre-processamento por linha (linha " + line.LineNumber + ", " + currentFile + ")");
            }
        }
    }
}

