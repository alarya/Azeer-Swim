using Nop.Core.Domain.Catalog;

namespace Nop.Data.Mapping.Catalog
{
    public partial class ProductHeartMap : NopEntityTypeConfiguration<ProductHeart>
    {
        public ProductHeartMap()
        {
            this.ToTable("ProductHeart");
            this.HasKey(pr => pr.Id);

            this.HasRequired(pr => pr.Product)
                .WithMany(p => p.ProductHearts)
                .HasForeignKey(pr => pr.ProductId);

            this.HasRequired(pr => pr.Customer)
                .WithMany()
                .HasForeignKey(pr => pr.CustomerId);
        }
    }
}