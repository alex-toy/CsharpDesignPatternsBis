﻿using System;

namespace DesignPatterns.Commands
{
    public class HighLightText : ICommand
    {
        public HighLightText(string text, HighLightConfig config)
        {

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
