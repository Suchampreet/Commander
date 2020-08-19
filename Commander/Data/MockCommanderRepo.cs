using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 1, HowTo = "do11.....", Line = "lineeee1", Platform = "c#" },
                new Command { Id = 2, HowTo = "do22.....", Line = "lineeee2", Platform = "c#" },
                new Command { Id = 3, HowTo = "do33.....", Line = "lineeee3", Platform = "c#" }
        };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 1, HowTo = "do.....", Line = "lineeee1", Platform = "c#" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
