using PruebaTecnicaSysorg.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaSysorg.Services
{
    public class CommandsService
    {
        List<Add> files = Program.list;
        public bool TypeCommand(string command) 
        {
            //instruction is the first word in command which introduces the user 
            var instruction = command.Split(' ').First();            
            //compare the instruction with others
            switch (instruction) 
            {
                case "exit":
                    return false;               
                case "add":
                    files.Add(new AddCommandServices().addcommand(command));
                    return true;                
                case "commit":
                    new CommitCommandServices().Commitcommand(files);
                    return true;               
                case "push":
                    new PushCommandServices().pushcommand();
                    
                    return true;
                case "log":
                    new LogCommandServices().Logcommand();
                    return true;
                case "help":
                    new HelpCommandServices().helpcommand();
                    return true;
                default: 
                    return true;
            }
        }
    }
}
