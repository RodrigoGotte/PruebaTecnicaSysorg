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
            Console.WriteLine("|| FECHA DE CREACION || ARCHIVOS AÑADIDOS || MENSAJES ||");
            foreach (var commit in history) 
            {
                Console.WriteLine($"||{commit.InsertDate} || {commit.Files[0].NameFile} || {commit.Message} ||");
                commit.Files.Remove(commit.Files[0]);
                foreach (var archivo in commit.Files ) 
                { Console.WriteLine($"                     || {archivo.NameFile}                             ||"); }
            }
        }
    }
}
