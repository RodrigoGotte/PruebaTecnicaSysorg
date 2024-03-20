using PruebaTecnicaSysorg.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaSysorg.Services
{
    public class PushCommandServices
    {
        public bool pushcommand(Commit commit) 
        {
            try 
            {
                if (commit.InsertDate == null) 
                    throw new Exception("PUSH COMMAND : NO EXISTE COMMIT");
                Console.WriteLine("PUSH COMMAND : Push is starting!");
                Console.WriteLine("PUSH COMMAND : connecting to server");
                Console.WriteLine("PUSH COMMAND : Push was finish and succesful!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("PUSH COMMAND : NO FUNCIONO");
                return false;
            }                        
        }
    }
}
