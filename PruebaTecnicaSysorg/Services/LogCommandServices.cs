using Microsoft.Win32;
using PruebaTecnicaSysorg.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaSysorg.Services
{
    public class LogCommandServices
    {        
        public void Logcommand(List<Commit> history) 
        {
            int anchoTabla = 80;

            // Caracteres para borde y separadores
            char bordeHorizontal = '_';
            char bordeVertical = '|';            
            char espacio = ' ';
            int ncommit = 0;

            // Crear StringBuilder
            StringBuilder sb = new StringBuilder();

            foreach (var registro in history)
            {
                sb.AppendLine($"{bordeHorizontal.ToString().PadLeft(anchoTabla, bordeHorizontal)}");
                ncommit++;
                sb.AppendLine($"{bordeVertical.ToString() + ncommit}° COMMIT");
                
                // Agregar encabezado
                sb.AppendLine($"{bordeHorizontal.ToString().PadLeft(anchoTabla, bordeHorizontal)}");            
                sb.AppendLine($"{bordeVertical} FECHA CREACION {bordeVertical.ToString().PadLeft(5)} MENSAJES");
                sb.AppendLine($"{bordeHorizontal.ToString().PadLeft(anchoTabla, bordeHorizontal)}");

                // Agregar filas            
                sb.AppendLine($"{bordeVertical} {registro.InsertDate.ToString().PadLeft(15, espacio)} {bordeVertical} {registro.Message.PadLeft(1, espacio)}");
                sb.AppendLine($"{bordeHorizontal.ToString().PadLeft(anchoTabla, bordeHorizontal)}");
                sb.AppendLine($"{bordeVertical} ARCHIVOS AÑADIDOS  ");
                sb.AppendLine($"{bordeHorizontal.ToString().PadLeft(anchoTabla, bordeHorizontal)}");
                foreach (var archivo in registro.Files)
                {
                    sb.AppendLine($"{bordeVertical}{archivo.NameFile}");
                }
                sb.AppendLine($"{bordeHorizontal.ToString().PadLeft(anchoTabla, bordeHorizontal)}");
                sb.AppendLine();
                sb.AppendLine();                
            }
            // Imprimir la tabla
            Console.WriteLine(sb.ToString());
        }
    }
}
