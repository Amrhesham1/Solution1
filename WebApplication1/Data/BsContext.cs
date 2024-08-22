using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OFlow_Api.Data;

public partial class BsContext : IdentityDbContext<ApiUser>
{
    public BsContext()
    {
    }

    public BsContext(DbContextOptions<BsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Amr> Amrs { get; set; }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Table> Tables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\sqlexpress;Database=bs;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Amr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Amr__3214EC07A0D2794E");

            entity.ToTable("Amr");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Authors__3214EC072F798545");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Table__3214EC07CF5695CC");

            entity.ToTable("Table");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Name = "User",
                NormalizedName = "USER",
                Id = "8218aae3-3ae8-4014-a970-c0f845fbf543"
            },
               new IdentityRole
               {
                   Name = "Administrator",
                   NormalizedName = "ADMINISTRATOR",
                   Id = "abf1b18d-ef95-4550-9b00-ec28ed98ef9a"
               }
            );

        var hasher = new PasswordHasher<ApiUser>();
        modelBuilder.Entity<ApiUser>().HasData(
            new ApiUser
            {
               
                Id = "0e044385-6582-4d16-90f7-848f5e93f30f",
                Email="admin@bookstore.com",
                NormalizedEmail="ADMIN@BOOKSTORE.COM",
                 UserName = "admin@bookstore.com",
                NormalizedUserName = "ADMIN@BOOKSTORE.COM",
                FirstName="system",
                LastName="admin",
                PasswordHash=hasher.HashPassword(null,"P@ssword1")
            },
               new ApiUser
               {
               
                   Id = "8d8389e0-b360-4bc9-97d3-a2618e3cd18c",
                   Email = "User@bookstore.com",
                   NormalizedEmail = "USER@BOOKSTORE.COM",
                   UserName = "User@bookstore.com",
                   NormalizedUserName = "USER@BOOKSTORE.COM",
                   FirstName = "system",
                   LastName = "User",
                   PasswordHash = hasher.HashPassword(null, "P@ssword2")
               }


            );

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "8218aae3-3ae8-4014-a970-c0f845fbf543",
                UserId = "8d8389e0-b360-4bc9-97d3-a2618e3cd18c"
            },

             new IdentityUserRole<string>
             {
                 RoleId = "abf1b18d-ef95-4550-9b00-ec28ed98ef9a",
                 UserId = "0e044385-6582-4d16-90f7-848f5e93f30f"
             }

            );


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
