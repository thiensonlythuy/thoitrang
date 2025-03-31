using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using shop.Abstracts;
using Shop.model;

namespace shop.Model{
    [Table("address")]
    public class Address : BaseModel {
        [ForeignKey("Ward")]
        [Required]public int ward_id{set;get;}
        [Required][StringLength(70)]public string? house_numbering{set;get;}
        [Required]public int addressable_id{set;get;}
        [Required][StringLength(50)]public string addressable_type{set;get;}
        public Wards Ward{set;get;} = null!;
        public ICollection<Users> Users{get;} = new List<Users>();
        public ICollection<Shipping> Shipping{get;} = new List<Shipping>();
    }
}