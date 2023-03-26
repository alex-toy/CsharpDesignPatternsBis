using System;

namespace DesignPatterns
{
    internal class DynamicCommand<T>
    {
        private T _receiver;
        private Action<T> _action;

        public DynamicCommand(T receiver, Action<T> action)
        {
            _receiver = receiver;
            _action = action;
        }

        public void Execute()
        {
            _action(_receiver);
        }
    }
}