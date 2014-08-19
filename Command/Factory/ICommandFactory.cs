using Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.Factory
{
    public interface ICommandFactory
    {
        ICommand MakeCommand(string commandName);
    }
}
