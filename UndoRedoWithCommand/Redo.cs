namespace UndoRedoWithCommand
{
    /// <summary>
    /// concerete command
    /// </summary>
    public class Redo : ICommand
    {
        private UndoRedo UnoRedo;
        public Redo(UndoRedo UnoRedo)
        {
            this.UnoRedo = UnoRedo;
        }
        public string Execute(string word)
        {
            return UnoRedo.Redo(word);
        }
    }
}
