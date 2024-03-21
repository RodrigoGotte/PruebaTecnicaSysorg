using PruebaTecnicaSysorg.Clases;

namespace PruebaTecnicaSysorg.Services
{
    public class AddCommandServices
    {
        public Add addcommand(string command)
        {
            try
            {
                //Get the name file of the command
                var namefile = command.Split(' ').GetValue(1).ToString();
                var addclass = new Add
                {
                    //Check if the message is empty and throw exception
                    NameFile = namefile != string.Empty ? namefile : throw new Exception(),
                };
                Console.WriteLine("ADD COMMAND : THE FILE WAS ADDED SUCCESFULLY!");
                return addclass;
            }            
            catch (Exception ex)
            {
                Console.WriteLine("ADD COMMAND ERROR : FILE NOT FOUND!");
                Console.WriteLine(ex);
                return null;
            }            
        }
    }
}
