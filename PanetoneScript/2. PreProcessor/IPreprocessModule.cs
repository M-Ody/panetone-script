namespace PanetoneScript.PreProcessor
{
    public interface IPreprocessModule
    {
        void Process(ref ScriptFile scriptFile);
    }
}
