using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProAPI.Models;

namespace ProAPI.Repo
{
    public interface IRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandByID(int id);
        void CreateCommand(Command cmd);
    }
}
