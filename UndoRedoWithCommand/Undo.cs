using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoRedoWithCommand
{
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
