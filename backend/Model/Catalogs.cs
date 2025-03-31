

using System.ComponentModel.DataAnnotations.Schema;
using shop.Abstracts;

namespace Shop.Model{
    [Table("catalog")]
    public class Catalogs :BaseModel{
        public Boolean status{set;get;} = true;
        public int? parent_id{set;get;}

        public ICollection<CatalogTranslation> catalogTranslations = new List<CatalogTranslation>();
    }
}