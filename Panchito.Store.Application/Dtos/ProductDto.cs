using System.ComponentModel.DataAnnotations;

namespace Panchito.Store.Application.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }    
        public string code { get; set; }     
        public string Name { get; set; }      
        public string Description { get; set; }
        public int Stok { get; set; }
    }
}
