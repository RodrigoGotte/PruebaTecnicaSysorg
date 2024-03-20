namespace PruebaTecnicaSysorg.Clases
{
    public class Commit
    {        
        public required List<Add> Files { get; set; }      
        public string Message { get; set; }
        public DateTime? InsertDate { get; set; }
    
        public Commit Clear() 
        {
            return new Commit{
                Files = new List<Add>(),
                Message = string.Empty,
                InsertDate = null
            };
        }        
    }    
}
