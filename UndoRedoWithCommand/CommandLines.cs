using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoRedoWithCommand
{
    public class CommandLines
    {
        private ICommand command;

        public void AddCommand(ICommand command)
        {
            this.command = command;
        }

        public string PlaceCommans(string word)
        {
            return command.Execute(word);
        }

    }
}
