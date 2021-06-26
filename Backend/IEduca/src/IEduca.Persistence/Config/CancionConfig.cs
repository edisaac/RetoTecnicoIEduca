using IEduca.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IEduca.Persistence.Config
{
    public class CancionConfig
    {
        public CancionConfig(EntityTypeBuilder<Cancion> entityBuilder)
        {
            entityBuilder.Property(e => e.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            entityBuilder.Property(e => e.Nombre).HasColumnType("varchar(220)").IsRequired();
            entityBuilder.Property(e => e.Enlace).HasColumnType("varchar(500)");
        }
    }
}
