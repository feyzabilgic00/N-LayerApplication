using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using N_Layer.Core.Entities;

namespace N_Layer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
            new Product
            {
                Id = 1,
                Name = "Ürün 1",
                CategoryId = 1,
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now,
            },
            new Product
            {
                Id = 2,
                Name = "Ürün 2",
                CategoryId = 2,
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now,
            },
            new Product
            {
                Id = 3,
                Name = "Ürün 3",
                CategoryId = 3,
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now,
            },
            new Product
            {
                Id = 4,
                Name = "Ürün 4",
                CategoryId = 1,
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now,
            },
            new Product
            {
                Id = 5,
                Name = "Ürün 5",
                CategoryId = 2,
                Price = 100,
                Stock = 20,
                CreatedDate = DateTime.Now,
            });
        }
    }
}
