using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Commands
{
    internal class CommandUndo : CommandUser
    {
        CommandManager manager;

        public CommandUndo(CommandManager manager)
        {
            this.manager = manager;
        }

        public override void Execute()
        {
            manager.UndoLastCommand();
        }
    }
}
