using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Employee
    {
        private const string V = "ID Nhân Viên";

        [DisplayName(V)]
        public int EmployeeID{ get; set; }
        [DisplayName("Số điện thoại")]
        public int PhoneNumber { get; set; }
        
       [DisplayName("Tên Nhân Viên")]
        public string EmployeeName  { get; set; }
        
    }
}
