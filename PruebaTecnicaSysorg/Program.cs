using PruebaTecnicaSysorg.Clases;
using PruebaTecnicaSysorg.Controllers;

class Program
{
    //Create a global variables to keep in memory 
    public static Commit CommitCache = new Commit { Files = new List<Add>(), InsertDate = null, Message = string.Empty };
    public static List<Commit> CommitHistory = new List<Commit>();

    static void Main() 
    {
        Console.Clear();
        Console.WriteLine("Welcome to SysorgHUB");
        Console.WriteLine("Write  command.... ");
        Console.WriteLine();
        //This is used for the user to use commands until the user uses the "exit" command.    
        bool continuity = true;
        while (continuity) 
        {
            continuity = new CommandsControllers().TypeCommand(Console.ReadLine());
        }
    }
    
}
