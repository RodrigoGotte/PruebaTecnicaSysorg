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
        Commit commit = Program.list;
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
                    commit.Files.Add(new AddCommandServices().addcommand(command));
                    return true;                
                case "commit":
                    var tarea = new CommitCommandServices().Commitcommand(commit.Files,command);
                    commit.Message = tarea.Message;
                    commit.InsertDate = tarea.InsertDate;
                    return true;               
                case "push":
                    bool push = new PushCommandServices().pushcommand(commit);
                    if (push)
                        commit.Clear();
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
