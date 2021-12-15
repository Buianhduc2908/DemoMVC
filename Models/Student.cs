using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace MvcMovie.Models
{
    

    public class Student : Person
    {
        
    
        public String studentCode { get; set; }
        
        
        public string Address  { get; set; }
        public string University  { get; set; }
        
    
        
    
        
    }
}
