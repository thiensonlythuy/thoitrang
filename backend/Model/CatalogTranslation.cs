

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using shop.Abstracts;

namespace Shop.Model{
    [Table("catalog_translation")]
    public class CatalogTranslation :BaseModel{
        [ForeignKey("Catalogs")]
        [Required]public int catalog_id{set;get;}
        [ForeignKey("languages")]
        [Required]public int language_id{set;get;}
        [Required][StringLength(50)]public string name{set;get;}
        public string? descriptions{set;get;}
        public Languages languages{set;get;} = null!;
        public Catalogs catalogs{set;get;} = null!;

    }
}