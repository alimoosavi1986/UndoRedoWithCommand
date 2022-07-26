namespace UndoRedoWithCommand
{
    /// <summary>
    /// concerete command
    /// </summary>
    public class Undo : ICommand
    {
        private UndoRedo UnoRedo;
        public Undo(UndoRedo UnoRedo)
        {
            this.UnoRedo = UnoRedo;
        }
        public string Execute(string word)
        {
            return UnoRedo.Undo(word);
        }
    }
}
