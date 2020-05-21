namespace MortalEngines.IO.Contracts
{
    public interface IWriter
    {
        void Write(string content);
        void WriteLine(string v);
    }
}