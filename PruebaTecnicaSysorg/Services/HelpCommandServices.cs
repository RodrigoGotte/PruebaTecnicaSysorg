
namespace PruebaTecnicaSysorg.Services
{
    public class HelpCommandServices
    {
        public void helpcommand() 
        {
            Console.WriteLine("HELP : Se utiliza para ver los comandos posibles y para que se utilizan.");
            Console.WriteLine("ADD : Se utiliza para agregar los archivos que se necesita para utilizar el 'commit' y realizar la subida.");
            Console.WriteLine("COMMIT : Se utiliza para guardar los archivos subidos y colocar un mensaje describiendo los cambios.");
            Console.WriteLine("PUSH : Se utiliza para subir los cambios a la nube.");
            Console.WriteLine("LOG : Se utiliza para ver el historial de los cambios hechos en la nube.");            
        }
    }
}
