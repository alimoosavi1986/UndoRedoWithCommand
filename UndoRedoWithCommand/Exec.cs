namespace UndoRedoWithCommand
{
    public class Exec : ICommand
    {
        /// <summary>
        /// invoker or reciver
        /// </summary>
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
