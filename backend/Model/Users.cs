using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using shop.Abstracts;
using Shop.Model;

namespace shop.Model{
    [Table("users")]
    [Index(nameof(email), IsUnique = true)]
    [Index(nameof(Phone), IsUnique = true)]
    public class Users :BaseModel {
    [Required] [StringLength(50)]public string fullname{get;set;}
    [Required] [EmailAddress][StringLength(50)]private string email{get;set;}
    [Required][StringLength(20)]public string password{set;get;}
    public string? avatar{set;get;}
    [ForeignKey("Address")]
    [Required]public int address_id{set;get;}
    [Required]public int gender{set;get;}
    [StringLength(20)]public string status{set;get;} = "Bình Thường";
    [Required][Column(TypeName ="char(10)")][DefaultValue("User")] public UserRole role{set;get;}
    [Column(TypeName ="varchar(25)")]private string? _phone;
    [Required][Column(TypeName ="smalldatetime")]public DateTime birthday{set;get;}
    public string? remember_token{set;get;}
    public DateTime? email_verified_at{set;get;}
     public string Phone => _phone ?? ""; // Getter

    public void SetPhone(string phone) => _phone = phone.Replace(" ", "").Trim();//Setter
    public Address Address {get;set;} = null!;
    public ICollection<Orders> Orders{get;} = new List<Orders>();
    public ICollection<Carts> Carts{get;} = new List<Carts>();
    public ICollection<Reviews> Reviews{get;} = new List<Reviews>();
    
    };
    public enum UserRole{Admin,User,Guest}
}