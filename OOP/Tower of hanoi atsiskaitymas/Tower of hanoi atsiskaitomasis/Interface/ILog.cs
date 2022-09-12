namespace TowerOfHanoi.Interface
{
    public interface ILog
    {
        void Log(string[] data, string data1);
        string[] CreateCsvLogText(string[] data);
        string CreateHtmlLogText(string[] data);
        string CreateTxtLogText(string[] data);
    }
}
