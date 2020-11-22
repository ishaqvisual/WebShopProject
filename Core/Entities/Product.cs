using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Product //: BaseEntity
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string PictureUrl { get; set; }

        public virtual ProductType ProductType { get; set; }

        public int ProductTypeId { get; set; }

        public virtual ProductBrand ProductBrand { get; set; }

        public int ProductBrandId { get; set; }
    }
}
