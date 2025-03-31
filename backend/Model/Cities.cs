


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using shop.Abstracts;

namespace shop.Model{
    [Table("cities")]
    public class Cities : BaseModel{
        [Required][StringLength(30)]public string name{set;get;}
        [Required][Column(TypeName ="char(10)")] public string abbreviation{set;get;}
        public ICollection<Wards> Wards{get;} = new List<Wards>();
    }
}