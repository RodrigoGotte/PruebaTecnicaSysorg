using PruebaTecnicaSysorg.Controllers;

class Program
{
    static void Main() 
    {
        bool lala = true;
        while (lala) 
        {
            lala = new Userchoose().CommandChooser();
        }
    }
    
}
