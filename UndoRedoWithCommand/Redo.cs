using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoRedoWithCommand
{
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
