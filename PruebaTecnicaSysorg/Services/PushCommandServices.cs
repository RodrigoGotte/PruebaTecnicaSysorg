using PruebaTecnicaSysorg.Clases;

namespace PruebaTecnicaSysorg.Services
{
    public class PushCommandServices
    {
        public bool pushcommand(Commit commit) 
        {
            try 
            {
                if (commit.InsertDate == null) 
                    throw new Exception("PUSH COMMAND : COMMIT DOESN´T EXIST");
                Console.WriteLine("PUSH COMMAND : Push is starting!");
                Console.WriteLine("PUSH COMMAND : connecting to server");
                Console.WriteLine("PUSH COMMAND : Push was finish and succesful!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }                        
        }
    }
}
