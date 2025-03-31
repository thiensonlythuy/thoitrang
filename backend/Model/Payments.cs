

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using shop.Abstracts;

namespace Shop.Model{
    [Table("payments")]
    public class Payments:BaseModel{
        [StringLength(50)] public string? payment_method{set;get;}
        public Boolean status{set;get;} = true;
        [StringLength(100)]public string? transaction_id{set;get;}
        [ForeignKey("Order")]
        [Required]public int order_id{set;get;}
        public Orders Order{get;set;} = null!;
    }
}