using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaSysorg.Controllers
{
    public class UserWriteController
    {
        public bool CommandChooser() 
        {
            var command = Console.ReadLine();                                    
            return new CommandsControllers().TypeCommand(command); ; 
        }
    }
}
