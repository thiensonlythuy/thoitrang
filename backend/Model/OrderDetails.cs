

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using shop.Abstracts;

namespace Shop.Model{
    [Table("order_details")]
    public class OrderDetails:BaseModel{
        [ForeignKey("Order")]
        [Required] public int order_id{set;get;}
        [ForeignKey("Product")]
        [Required] public int product_id{set;get;}
        [Required] public int quantity{set;get;}
        [Required][Column(TypeName ="Money")]public Decimal total_price{set;get;} 

        public Orders Order{set;get;} = null!;
        public Products Product{set;get;} =null!;
    }
}