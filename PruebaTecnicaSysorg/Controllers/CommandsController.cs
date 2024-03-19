using PruebaTecnicaSysorg.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaSysorg.Controllers
{
    public class CommandsControllers
    {
        public bool TypeCommand(string command) 
        {
            return new CommandsService().TypeCommand(command);
        }
    }
}
