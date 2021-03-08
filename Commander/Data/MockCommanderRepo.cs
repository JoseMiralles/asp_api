using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data
{

    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {

            List<Command> commands = new List<Command>
            {
                new Command {
                    Id = 0,
                    HowTo = "Boil an egg",
                    Line = "Boil water",
                    Platform = "Kettle and pan"
                },
                new Command {
                    Id = 0,
                    HowTo = "Make a cup of tea",
                    Line = "Boil water",
                    Platform = "Kettle and pot"
                },
                new Command {
                    Id = 0,
                    HowTo = "Slice bread",
                    Line = "Get a knife",
                    Platform = "Chopping board"
                }
            };

            return commands;

        }

        public Command GetCommandById(int id)
        {

            return new Command {
                    Id = 0,
                    HowTo = "Boil an egg",
                    Line = "Boil water",
                    Platform = "Kettle and pan"
                };

        }
    }

}