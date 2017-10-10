namespace Isaris.DataAccess.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("expob.facturas")]
    public class Invoice
    {
        [Key]
        [Column("codfactura", TypeName = "uint")]
        public int Id { get; set; }

        [Column("codcliente")]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [StringLength(255)]
        [Column("vendedor")]
        public string SellerName { get; set; }

        [Column("fecha")]
        public DateTime Date { get; set; }

        [Column("descuento")]
        public decimal Discount { get; set; }

        [Column("isv")]
        public decimal Isv { get; set; }

        [Column("total")]
        public decimal Total { get; set; }
        
        public virtual Customer Customer { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
