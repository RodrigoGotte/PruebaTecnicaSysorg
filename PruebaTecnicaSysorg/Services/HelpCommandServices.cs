
namespace PruebaTecnicaSysorg.Services
{
    public class HelpCommandServices
    {
        public void helpcommand() 
        {
            Console.WriteLine("HELP : Used to see the possible commands and what they are used for.");
            Console.WriteLine("ADD : It is used to add the files that are needed to use the 'commit' and perform the upload.");
            Console.WriteLine("COMMIT : It is used to save the uploaded files and place a message describing the changes.");
            Console.WriteLine("PUSH : It is used to upload changes to the cloud.");
            Console.WriteLine("LOG : Used to view the history of changes made in the cloud.");            
        }
    }
}
