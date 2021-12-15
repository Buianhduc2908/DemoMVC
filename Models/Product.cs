using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Product
    {
        [System.ComponentModel.DisplayName("ID Sản Phẩm")]
        public int ProductID { get; set; }
         [DisplayName("Đơn Giá")]
        public int UnitPrice { get; set;}
         [DisplayName("Số Lượng")]
        public int Quantity  { get; set;}
        [DisplayName("Tên Sản Phẩm")]
        public string ProducName { get; set; }

    }
}