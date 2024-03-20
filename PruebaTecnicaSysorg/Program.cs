using PruebaTecnicaSysorg.Clases;
using PruebaTecnicaSysorg.Controllers;

class Program
{
    public static Commit list = new Commit { Files = new List<Add>(), InsertDate = null, Message = string.Empty };
    static void Main() 
    {        
    bool lala = true;
        while (lala) 
        {
            lala = new UserWriteController().CommandChooser();
        }
    }
    
}
