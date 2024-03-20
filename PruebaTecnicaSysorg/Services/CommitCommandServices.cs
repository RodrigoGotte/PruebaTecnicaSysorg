using PruebaTecnicaSysorg.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaSysorg.Services
{
    public class CommitCommandServices
    {
        public Commit Commitcommand(List<Add> files,string command) 
        {
            try 
            {
                var message = command.Split(' ').GetValue(1).ToString();
                var commit = new Commit
                {
                    Files = files,
                    InsertDate = DateTime.Now,
                    Message = message == null || message == string.Empty ? throw new Exception("COMMIT COMMAND ERROR : No se escribio el mensaje") : message
                };
                Console.WriteLine("COMMIT COMMAND: Se commiteo exitosamente");
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
