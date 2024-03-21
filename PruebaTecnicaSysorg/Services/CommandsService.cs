using PruebaTecnicaSysorg.Clases;

namespace PruebaTecnicaSysorg.Services
{
    public class CommandsService
    {
        
        Commit cache = Program.CommitCache;
        List<Commit> history = Program.CommitHistory;

        public bool TypeCommand(string command) 
        {
            //option is the first word in command which introduces the user 
            var option = command.Split(' ').First().ToLower();

            //Compare the instruction with others
            switch (option) 
            {
                //This command close the program
                case "exit":
                    return false;

                //This command add files in the commitCache
                case "add":
                    var fileAdd = new AddCommandServices().addcommand(command);
                    if (fileAdd != null) 
                    { 
                        cache.Files.Add(fileAdd);
                    }                    
                    return true;
                
                //This command add message and date in the commitCache 
                case "commit":
                    var task = new CommitCommandServices().Commitcommand(cache.Files,command);
                    if (task != null)
                    {
                        cache.Message = task.Message;
                        cache.InsertDate = task.InsertDate;
                    }                    
                    return true;
                
                //This command add the commit in commitHistory and restart the commitCache to do again the proccess if the user want a new commit.
                case "push":
                    bool push = new PushCommandServices().pushcommand(cache);                    
                    if (push)
                    {                        
                        //I need to make a new variable so that the commit is saved and then restored
                        var commitpush = new Commit { Files=cache.Files, InsertDate= cache.InsertDate, Message= cache.Message };
                        history.Add(commitpush);
                        //Restart CommitCache
                        cache.Files = new List<Add>();
                        cache.Message = string.Empty;
                        cache.InsertDate = null;
                    }                    
                    return true;
                
                //This command show the other commit created in the session
                case "log":
                    new LogCommandServices().Logcommand(history);
                    return true;
                
                //This command show the other commands can use the user
                case "help":
                    new HelpCommandServices().helpcommand();
                    return true;

                default:
                    Console.WriteLine("COMMAND EXCEPTION : THE COMMAND IS NOT RECOGNIZED -- TRY 'HELP' TO SHOW COMMANDS CAN YOU USE.");
                    return true;
            }
        }
    }
}
