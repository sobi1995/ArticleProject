namespace Versioning_ASP.Net_Core_3_APIs_with_Swashbuckle.Model
{
     public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public int Price { get; set; }    
        public string Content { get; set; }
        public bool IsExit { get; set; }   
    }
}