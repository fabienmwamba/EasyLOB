using System.Data.Entity.ModelConfiguration;
using EasyLOB.Security.Data;

namespace EasyLOB.Security.Persistence
{
    public class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        public RoleConfiguration()
        {
            #region Class

            this.ToTable("AspNetRoles");

            this.HasKey(x => x.Id);

            #endregion Class

            #region Properties

            this.Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("varchar")
                .HasMaxLength(128)
                .IsRequired();

            this.Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("varchar")
                .HasMaxLength(256)
                .IsRequired();

            this.Property(x => x.Discriminator)
                .HasColumnName("Discriminator")
                .HasColumnType("varchar")
                .HasMaxLength(128)
                .IsRequired();

            #endregion Properties
        }
    }
}