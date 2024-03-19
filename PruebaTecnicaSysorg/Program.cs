using PruebaTecnicaSysorg.Clases;
using PruebaTecnicaSysorg.Controllers;

class Program
{
    public static List<Add> list = new List<Add>();
    static void Main() 
    {        
    bool lala = true;
        while (lala) 
        {
            lala = new UserWriteController().CommandChooser();
        }
    }
    
}
