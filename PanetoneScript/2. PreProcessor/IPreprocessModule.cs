using PanetoneScript.PSLog;

namespace PanetoneScript.PreProcessor
{
    public interface IPreprocessModule
    {
		void Process(ref ScriptFile scriptFile, ref LogList log);
    }
}
