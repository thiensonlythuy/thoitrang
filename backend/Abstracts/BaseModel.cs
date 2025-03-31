using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata;

namespace shop.Abstracts{
    public abstract class BaseModel{
        [Key]
        public int id{set;get;}
        // [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime created_at{get;set;}
        // [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? updated_at{get;set;} 

    } 
}