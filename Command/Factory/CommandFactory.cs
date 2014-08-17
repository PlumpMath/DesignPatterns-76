using Command.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Command.Factory
{
    public class CommandFactory : ICommandFactory
    {
        private Dictionary<string, Type> commands;

        public CommandFactory()
        {
            LoadTypesICanRun();
        }


        public ICommand MakeCommand(string commandName)
        {
            ICommand commandToReturn;

            Type t = GetTypeToCreate(commandName);

            if (t == null)
                commandToReturn = new NullCommand();
            else
                commandToReturn = Activator.CreateInstance(t) as ICommand;

            return commandToReturn;
        }

        private Type GetTypeToCreate(string commandName)
        {
            Type commandType = null;
            foreach (var command in commands)
            {
                if (command.Key.Contains(commandName))
                {
                    commandType = commands[command.Key];
                    break;
                }
            }

            return commandType;
        }

        private void LoadTypesICanRun()
        {
            commands = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type t in typesInThisAssembly)
            {
                if (t.GetInterface(typeof(ICommand).ToString()) != null)
                    commands.Add(t.Name, t);
            }
        }
    }
}
