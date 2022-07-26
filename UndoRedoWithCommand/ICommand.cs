namespace UndoRedoWithCommand
{
    /// <summary>
    /// Command
    /// </summary>
    public interface ICommand
    {
        string Execute(string word);
    }
}
