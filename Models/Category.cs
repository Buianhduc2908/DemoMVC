using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace MvcMovie.Models
{
    
    [Table("Categories")]
    public class Category
    {
        [Key]
        
    
        public int CategoryID { get; set; }
        
        
        public string CategoryName  { get; set; }
        
        
    
        
    
        
    }
}
