


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using shop.Abstracts;

namespace shop.Model{
    [Table("wards")]
    public class Wards : BaseModel{
        [ForeignKey("Cities")]
        [Required]public int city_id{set;get;}
        [Required][Column(TypeName ="nvarchar(30)")]public string name{set;get;}
        [Required][Column(TypeName ="char(10)")] public string abbreviation{set;get;}
        public Cities Cities {set;get;} =null!;
        public ICollection<Address> Address{get;}= new List<Address>(); 
    }
}