using System;
using System.Collections.Generic;

namespace UndoRedoWithCommand
{
    /// <summary>
    /// Invoker or reciver ?
    /// </summary>
    public class UndoRedo
    {
        private Stack<string> Forward { get; set; }
        private Stack<string> Backward { get; set; }
        public UndoRedo()
        {
            Forward = new Stack<string>();
            Backward = new Stack<string>();
        }
        public string Exec(string word)
        {
            Forward.Push(word);
            return word;
        }

        public string Undo(string word)
        {
            try
            {
                Backward.Push(Forward.Pop());
                return Forward.Peek();
            }
            catch (Exception)
            {
                return "";
            }
        }

        public string Redo(string word)
        {
            try
            {
                Forward.Push(Backward.Pop());
                return Backward.Peek();
            }
            catch (Exception)
            {
                return "";
            }
        }

    }
}
