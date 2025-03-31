


using System.ComponentModel.DataAnnotations.Schema;
using shop.Abstracts;
using shop.Model;

namespace Shop.Model{
    [Table("carts")]
    public class Carts:BaseModel{
        [ForeignKey("User")]
        public int user_id{set;get;}
        [ForeignKey("Product")]
        public int product_id{set;get;}
        public int quantity{set;get;}
        public Users User{set;get;} = null!;
        public Products Product {set;get;} = null!;
    }
}