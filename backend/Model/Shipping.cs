using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using shop.Abstracts;
using shop.Model;
using Shop.Model;

namespace Shop.model{
    [Table("shipping")]
    public class Shipping:BaseModel{
        [ForeignKey("Order")]
        [Required] public int order_id{set;get;}
        [ForeignKey("Address")]
        [Required] public int address_id{set;get;}
        [Required][StringLength(25)] public string tracking_number{set;get;}
        [Required][StringLength(50)] public ShippingStatus status{set;get;}
        [Required][Column(TypeName ="smalldatetime")] public DateTime estimated_delivery{set;get;}

        public Address Address{set;get;} = null!;
        public Orders Order{set;get;} =null!;
    }

    public enum ShippingStatus{
        Checking,
        Checked,
        Shipping,
        Complete,
        Refund

    }
}