

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using shop.Abstracts;
using shop.Model;
using Shop.model;
using Shop.Model;

public class AppDbContext : DbContext{
    public AppDbContext(DbContextOptions<AppDbContext>options) :base(options){}
    // khai báo bảng
    public DbSet<Cities> Cities{get;set;}
    public DbSet<Wards> Wards{get;set;}
    public DbSet<Address> Address {get;set;}
    public DbSet<Users> Users {get;set;}
    public DbSet<Images> Images{set;get;}
    public DbSet<Languages> Languages{get;set;}
    public DbSet<Catalogs> Catalogs{get;set;}
    public DbSet<CatalogTranslation> CatalogTranslation{get;set;}
    public DbSet<Orders> Orders{set;get;}
    public DbSet<Payments> Payments{set;get;}
    public DbSet<Products> Products{set;get;}
    public DbSet<OrderDetails> OrderDetails{set;get;}
    public DbSet<Reviews> Reviews {set;get;}
    public DbSet<Carts> Carts {set;get;}
    public DbSet<Shipping> Shipping {set;get;}

    //
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Users>().Property(e=>e.Phone).HasField("_phone").HasMaxLength(25).IsRequired();
        modelBuilder.Entity<Users>().Property(u=>u.role).HasConversion<string>();
        modelBuilder.Entity<Users>().Property(u=>u.status).HasConversion<int>();
        modelBuilder.Entity<Products>().Property(u=>u.status).HasConversion<int>();
        modelBuilder.Entity<Orders>().Property(u=>u.status).HasConversion<int>();
        modelBuilder.Entity<Catalogs>().Property(u=>u.status).HasConversion<int>();
        modelBuilder.Entity<Shipping>().Property(u=>u.status).HasConversion<string>();
        
        

        //set default value for updated_at and created_at in base entity models
        foreach(var baseEntity in modelBuilder.Model.GetEntityTypes()){
            if(typeof(BaseModel).IsAssignableFrom(baseEntity.ClrType)){
                modelBuilder.Entity(baseEntity.ClrType).Property<DateTime>("created_at").HasDefaultValueSql("GETDATE()");
                modelBuilder.Entity(baseEntity.ClrType).Property<DateTime?>("updated_at").ValueGeneratedOnUpdate();
                foreach(var foreignKey in baseEntity.GetForeignKeys()){
                    if (baseEntity.ClrType.Name == "Shipping" && foreignKey.PrincipalEntityType.ClrType.Name == "Orders")
                    {
                        foreignKey.DeleteBehavior = DeleteBehavior.NoAction;
                    }
                    else
                    {
                        foreignKey.DeleteBehavior = DeleteBehavior.Cascade;
                    }
                }
            }
        }

    }
}