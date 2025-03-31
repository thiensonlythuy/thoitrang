

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using shop.Abstracts;
using shop.Model;
using Shop.model;

namespace Shop.Model{
    [Table("orders")]
    public class Orders : BaseModel{
        [ForeignKey("User")]
        [Required]public int user_id{set;get;}
        [Column(TypeName ="Money")] public Decimal total_amount{set;get;}
        public Boolean status{set;get;} = true;
        public Users User{set;get;} = null!;
        public Payments? Payment {get;set;} = null!;
        public Shipping Shipping{set;get;} =null!;
        public ICollection<OrderDetails> OrderDetails{get;} = new List<OrderDetails>();
    }
}