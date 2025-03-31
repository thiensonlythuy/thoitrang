

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using shop.Abstracts;
using shop.Model;

namespace Shop.Model{
    [Table("reviews")]
    public class Reviews:BaseModel{
        [ForeignKey("User")]
        [Required] public int user_id{set;get;}
        [ForeignKey("Product")]
        [Required] public int product_id{set;get;}
        [Required] public int rating{set;get;}
        [Column(TypeName ="text")]public string? comments{set;get;}

        public Users User{set;get;} = null!;
        public Products Product {set;get;} =null!;
    }
}