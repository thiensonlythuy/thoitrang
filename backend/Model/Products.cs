


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using shop.Abstracts;

namespace Shop.Model{
    [Table("products")]
    public class Products:BaseModel{
        [StringLength(100)]public string name{set;get;}
        [StringLength(100)]public string image{set;get;}
        public string? descriptions{set;get;}
        [ForeignKey("Catalogs")]
        [Required] public int catalog_id{set;get;}
        public int discount{set;get;}
        [Required] public int stock{set;get;}
        public Boolean status{set;get;} = true;
        [Column(TypeName ="money")]public decimal price{set;get;}

        public OrderDetails? orderDetails {set;get;}
        public Catalogs Catalogs{set;get;} =null!;
        public ICollection<Reviews> Reviews{get;} = new List<Reviews>();
        public ICollection<Carts> carts{get;} = new List<Carts>();
    }
}