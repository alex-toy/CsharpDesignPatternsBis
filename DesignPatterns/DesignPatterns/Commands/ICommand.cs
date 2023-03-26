namespace DesignPatterns.Commands
{
    public interface ICommand
    {
        void Execute(HighLightConfig config);
        void Undo();
    }
}
