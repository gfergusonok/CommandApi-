using CommandApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandApi.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Models.Command> GetAllCommands();
        Models.Command GetCommandById(int id);
        void CreateCommand(Command command);
    }
}
