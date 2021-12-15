using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace MvcMovie.Models
{
    [Table("People")]

    public class Person
    {
        [Key]
    
        public String PersonID { get; set; }
        
        
        public string FullName  { get; set; }
        
    
        
    
        
    }
}
