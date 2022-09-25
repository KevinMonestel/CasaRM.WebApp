using CasaRM.WebApp.Persistence.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace CasaRM.WebApp.Persistance
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /* Tables Registration*/

        public virtual DbSet<Host> Host { get; set; }

        public virtual DbSet<SocialStudy> SocialStudy { get; set; }

        public virtual DbSet<MinorPersonData> MinorPersonData { get; set; }

        public virtual DbSet<ParentData> ParentData { get; set; }

        public virtual DbSet<CompanionData> CompanionData { get; set; }

        public virtual DbSet<FamilyGroup> FamilyGroup { get; set; }

        public virtual DbSet<Contribution> Contribution { get; set; }

        /* End Tables Registration*/

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "Usuarios");
            });

            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Roles");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("RolesUsuario");
                //in case you chagned the TKey type
                //  entity.HasKey(key => new { key.UserId, key.RoleId });
            });

            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("ClaimsUsuario");
            });

            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("LoginsUsuario");
                //in case you chagned the TKey type
                //  entity.HasKey(key => new { key.ProviderKey, key.LoginProvider });       
            });

            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("ClaimsRoles");

            });

            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("TokensUsuario");
                //in case you chagned the TKey type
                // entity.HasKey(key => new { key.UserId, key.LoginProvider, key.Name });

            });
        }
    }
}