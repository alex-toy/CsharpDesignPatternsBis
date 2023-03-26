using Command.Commands;

namespace Command.CommandManagers
{
    public interface ICommandManager
    {
        void Invoke(ICommand command);
        void Undo();
    }
}
