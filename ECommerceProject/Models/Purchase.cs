using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime InvoiceDate { get; set; }
        [Required]
        public string InvoiceNo { get; set; }
        [Required]
        public int ProdId { get; set; }
        public float PurchasePrice { get; set; }
        public int PurchaseQTY { get; set; }
        public int UnitId { get; set; }
        public int VendorId { get; set; }
    }
}
