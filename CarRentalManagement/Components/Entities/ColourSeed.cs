using BlazorApp2.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp2.Components.Entities {
    public class ColourSeed : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
                new Colour
                {
                    Id = 1,
                    Name = "Black",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    CreatedBy = "System",
                    ModifiedBy = "System"
                },
                new Colour
                {
                    Id = 2,
                    Name = "Blue",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    CreatedBy = "System",
                    ModifiedBy = "System"
                }
            );
        }
    }
}