using PruebaTecnicaSysorg.Clases;

namespace PruebaTecnicaSysorg.Services
{
    public class CommitCommandServices
    {
        public Commit Commitcommand(List<Add> files,string command) 
        {
            try 
            {   
                //Check if the user add a file
                if (files.Count() == 0) { throw new Exception("COMMIT COMMAND ERROR : FIRST UPLOAD A FILE."); }
                var message = command.Split(' ').GetValue(1).ToString();
                var commit = new Commit
                {
                    Files = files,
                    InsertDate = DateTime.Now,
                    //Check if the user write a message
                    Message = message == string.Empty ? throw new Exception("COMMIT COMMAND ERROR : DON'T WRITE THE MESSAGE") : message
                };
                Console.WriteLine("COMMIT COMMAND: THE COMMIT IS SUCCESFULLY.");
                return commit;
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }            
        }
    }
}
