using Command.Commands;
using System.Collections.Generic;

namespace Command.CommandManagers
{
    public class CommandManager : ICommandManager
    {
        private Stack<ICommand> _commands = new Stack<ICommand>();

        public void Invoke(ICommand command)
        {
            if (command.CanExecute())
            {
                _commands.Push(command);
                command.Execute();
            }
        }

        public void Undo()
        {
            var command = _commands.Pop();
            command.Undo();
        }
    }
}
