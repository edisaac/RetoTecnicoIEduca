using IEduca.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IEduca.Persistence.Config
{
    public class AlbumConfig
    {

        public AlbumConfig(EntityTypeBuilder<Album> entityBuilder)
        {
            entityBuilder.Property(e => e.Id).HasColumnType("int").UseMySqlIdentityColumn().IsRequired();
            entityBuilder.Property(e => e.Nombre).HasColumnType("varchar(220)").IsRequired();
            entityBuilder.Property(e => e.Artista).HasColumnType("varchar(220)").IsRequired();
            entityBuilder.Property(e => e.Portada).HasColumnType("varchar(500)");

            entityBuilder.HasMany(e => e.Canciones)
                      .WithOne(e => e.Album)
                      .HasForeignKey(e => e.AlbumId)
                      .IsRequired();
        }
    }
}
