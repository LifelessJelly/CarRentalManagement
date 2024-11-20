using BlazorApp2.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorApp2.Components.Entities {
    public class ModelSeed : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model { 
                    Id=1,
                    Name="i4"
                },
                new Model { 
                    Id=2,
                    Name="X5"
                },
                new Model { 
                    Id=3,
                    Name="Prius"
                },
                new Model { 
                    Id=4,
                    Name="C-HR"
                }
            );
        }
    }
}