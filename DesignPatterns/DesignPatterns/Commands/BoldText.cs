using System;

namespace DesignPatterns.Commands
{
    internal class BoldText : ICommand
    {
        public BoldText(string text)
        {

        }

        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void Execute(HighLightConfig config)
        {
            throw new NotImplementedException();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
