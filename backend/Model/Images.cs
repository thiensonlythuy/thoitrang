

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using shop.Abstracts;

namespace Shop.Model{
    [Table("images")]
    public class Images : BaseModel{
        [Required]public string src{set;get;}
        [Required][StringLength(50)]public string imageable_type{set;get;}
        [Required]public int imageable_id{get;set;}

    }
}