using PruebaTecnicaSysorg.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaSysorg.Services
{
    public class AddCommandServices
    {
        public Add addcommand(string command)
        {
            try
            {
                var namefile = command.Split(' ').GetValue(1).ToString();
                var addclass = new Add
                {
                    NameFile = namefile != string.Empty || namefile != null ? namefile : throw new Exception("ADD COMMAND ERROR : No se encuentra archivo"),                    
                };
                Console.WriteLine("ADD COMMAND : Se agrego el archivo exitosamente");
                return addclass;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
