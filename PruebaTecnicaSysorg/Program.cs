using PruebaTecnicaSysorg.Clases;
using PruebaTecnicaSysorg.Controllers;

class Program
{
    public static Commit CommitCache = new Commit { Files = new List<Add>(), InsertDate = null, Message = string.Empty };
    public static List<Commit> CommitHistory = new List<Commit>();

    static void Main() 
    {
        Console.Clear();
        bool continuidad = true;
        while (continuidad) 
        {
            continuidad = new CommandsControllers().TypeCommand(Console.ReadLine());
        }
    }
    
}
