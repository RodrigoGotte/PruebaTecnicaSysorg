using PruebaTecnicaSysorg.Clases;
using System.Text;

namespace PruebaTecnicaSysorg.Services
{
    public class LogCommandServices
    {        
        public void Logcommand(List<Commit> history) 
        {
            Console.Clear();
            //Width of the table
            int widthTabla = 80;
            
            //Chars to i need to use and Number of commits
            char horizontal = '_';
            char vertical = '|';            
            char blanksp = ' ';
            int ncommit = 0;

            // Create StringBuilder
            StringBuilder sb = new StringBuilder();

            foreach (var register in history)
            {
                // Add headers
                sb.AppendLine($"{horizontal.ToString().PadLeft(widthTabla, horizontal)}");
                ncommit++;
                sb.AppendLine($"{vertical.ToString() + ncommit}° COMMIT");                                
                sb.AppendLine($"{horizontal.ToString().PadLeft(widthTabla, horizontal)}");            
                sb.AppendLine($"{vertical}  CREATION DATE {vertical.ToString().PadLeft(5)} MESSAGES");
                sb.AppendLine($"{horizontal.ToString().PadLeft(widthTabla, horizontal)}");

                // Add rows            
                sb.AppendLine($"{vertical} {register.InsertDate.ToString().PadLeft(15, blanksp)} {vertical} {register.Message.PadLeft(1, blanksp)}");
                sb.AppendLine($"{horizontal.ToString().PadLeft(widthTabla, horizontal)}");
                //Add header to file upload
                sb.AppendLine($"{vertical}  FILES  ");
                sb.AppendLine($"{horizontal.ToString().PadLeft(widthTabla, horizontal)}");
                //Add rows to files
                foreach (var file in register.Files)
                {
                    sb.AppendLine($"{vertical}{file.NameFile}");
                }
                sb.AppendLine($"{horizontal.ToString().PadLeft(widthTabla, horizontal)}");
                sb.AppendLine();
                sb.AppendLine();                
            }
            // Print the table
            Console.WriteLine(sb.ToString());
        }
    }
}
