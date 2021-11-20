namespace BeautySaloonMVC.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            ProductSale = new HashSet<ProductSale>();
        }

        [Key]
        [StringLength(255)]
        public string Title { get; set; }

        public double Cost { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string MainImagePath { get; set; }

        [Required]
        [StringLength(255)]
        public string IsActive { get; set; }

        [StringLength(255)]
        public string ManufacturerName { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSale> ProductSale { get; set; }
    }
}
