namespace UndoRedoWithCommand
{
    public class Exec : ICommand
    {
        private UndoRedo UnoRedo;
        public Exec(UndoRedo UnoRedo)
        {
            this.UnoRedo = UnoRedo;
        }
        public string Execute(string word)
        {
            return UnoRedo.Exec(word);
        }
    }
}
