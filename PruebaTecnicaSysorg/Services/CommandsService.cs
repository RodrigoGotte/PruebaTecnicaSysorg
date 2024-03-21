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
        
        Commit cache = Program.CommitCache;
        List<Commit> history = Program.CommitHistory;

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
                    cache.Files.Add(new AddCommandServices().addcommand(command));
                    return true;
                    
                case "commit":
                    var tarea = new CommitCommandServices().Commitcommand(cache.Files,command);
                    cache.Message = tarea.Message;
                    cache.InsertDate = tarea.InsertDate;
                    return true;

                case "push":
                    bool push = new PushCommandServices().pushcommand(cache);                    
                    if (push)
                    {
                        var commitpusheado = new Commit { Files=cache.Files, InsertDate= cache.InsertDate, Message= cache.Message };
                        history.Add(commitpusheado);
                        cache.Files = new List<Add>();
                        cache.Message = string.Empty;
                        cache.InsertDate = null;
                    }                    
                    return true;

                case "log":
                    new LogCommandServices().Logcommand(Program.CommitHistory);
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
