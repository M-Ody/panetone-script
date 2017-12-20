using PanetoneScript.PanetoneScript;
using PanetoneScript.PSLog;
using System.Collections.Generic;

namespace PanetoneScript.PreProcessor
{
    public class RemoveStrings
    {
        ScriptFile[] processedScriptFiles;

        public void Process(ref ScriptFile[] scriptFiles, ref Log log, ref StringsRepository repo)
        {
            processedScriptFiles = new ScriptFile[scriptFiles.Length];

            for (int i = 0; i < scriptFiles.Length; i++)
            {
                RemoveStringsFromFile(ref scriptFiles[i], ref log, ref repo);
            }
        }

        private void RemoveStringsFromFile(ref ScriptFile script, ref Log log, ref StringsRepository stringsRepo)
        {
            var processedCodeLines = new List<ScriptLine>();
            ScriptLine[] lines = script.CodeLines;

            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i].LineCode;

                if (!currentLine.Contains("\""))
                {
                    var processedLine = new ScriptLine(lines[i].LineNumber, currentLine);
                    processedCodeLines.Add(processedLine);
                    continue;
                }

                Extract(ref lines, ref stringsRepo, ref i, ref processedCodeLines);
            }
        }

        private void Extract(ref ScriptLine[] lines, ref StringsRepository strings, ref int iterator, ref List<ScriptLine> processedCodeLines)
        {
            //firstIndexOfString
            //isMultiline
            //isString
            //hasFoundedQuoteOnLine
            //tempString

            //iterador de linhas i
            //      //iterar pelos chars j
            //          //se for aspas sem backslash
            //              //se string NÃO foi iniciada
            //                  //iniciar construção de string
            //                  //setar firstIndexOfString
            //              //senão
            //                  //se ja houver string no temp
            //                      //adicionar string ao temp
            //                      //salvar temp no repo
            //                      //trocar por #strN#
            //                      //ajustar valor do j
            //                      //resetar variaveis
            //                      //se j for ultimo E hasFoundedQuoteOnLine == false
            //                          //adicionar em strings processadas
            //                      //senão
            //                          //hasFoundedQuoteOnLine = true
            //CONTINUA DAQUI
            //          //se terminar linha
            //              //adicionar linha no processadas
            //              //salvar string ja retirada
            //              //trocar por #strN#
            //              //trocar de linha
            // !IMPORTANT: certificar-se de que, se houver uma multilinha, a linha posterior não seja pulada

            int firstIndexOfString = 0;
            bool isMultilineString = false;
            bool isString = false;
            string tempString = "";

            for (int i = iterator; i < lines.Length; i++)
            {
                string currentLine = lines[i].LineCode;
                for (int j = 0; j < currentLine.Length; j++)
                {
                    if (currentLine[j] == '\"' && (j == 0 || currentLine[j - 1] != '\\')
                        && tempString != "")
                    {
                        strings.Add(tempString);
                        string strIndex = "#str" + strings.GetLength() + "#";
                        currentLine.Replace(currentLine.Substring(firstIndexOfString, j - firstIndexOfString), strIndex);
                        j = currentLine.LastIndexOf(strIndex) + strIndex.Length;
                        if (j >= currentLine.Length) { j = currentLine.Length - 1; }
                    }

                    else if (currentLine[j] == '\"' && (j == 0 || currentLine[j - 1] != '\\'))
                    {
                        isString = true;
                    }

                    if (isString)
                    {
                    }

                    if (isMultilineString)
                    {
                        if (firstIndexOfString == 0)
                        {
                            tempString += currentLine[j];
                        }
                    }

                    if (j == currentLine.Length - 1)
                    {
                        if (isString)
                        {
                            isMultilineString = true;
                            tempString += currentLine;
                        }

                        if (!isMultilineString)
                        {
                            strings.Add(currentLine);
                        }
                    }
                }
            }
        }
    }
}
