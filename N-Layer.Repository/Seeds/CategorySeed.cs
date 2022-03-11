using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using N_Layer.Core.Entities;

namespace N_Layer.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
            new Category
            {
                Id = 1,
                Name = "Kategori 1",
            },
            new Category
            {
                Id = 2,
                Name = "Kategori 2",
            },
            new Category
            {
                Id = 3,
                Name = "Kategori 3",
            });
        }
    }
}
