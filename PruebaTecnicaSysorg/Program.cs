using PruebaTecnicaSysorg.Controllers;

class Program
{
    static void Main() 
    {
        bool x = true;
        while (x) 
        {
            x = new UserWriteController().CommandChooser();
        }
    }
    
}
