

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using shop.Abstracts;

namespace Shop.Model{
    [Table("languages")]
    public class Languages :BaseModel{
        [Required][StringLength(50)]public string name{set;get;}
        [Required][Column(TypeName ="char(10)")]public string abbreviation{set;get;}

        public ICollection<CatalogTranslation> CatalogTranslations {get;} = new List<CatalogTranslation>();
    }
}