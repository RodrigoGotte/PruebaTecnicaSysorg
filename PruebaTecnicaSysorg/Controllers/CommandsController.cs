using PruebaTecnicaSysorg.Services;

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
