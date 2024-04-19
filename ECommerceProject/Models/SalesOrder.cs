using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
    public class SalesOrder
    {
        public int Id { get; set; }
        [Required,DataType(DataType.Date)]
        public DateTime InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public int CustomerID { get; set; }
        public float TotalBillAmt { get; set; }
        public float Discount { get; set; }
        public float Vat { get; set; }
        public float ShippingCharge { get; set; }
        public float NetPayable { get; set; }
        public string Remarks { get; set; }
    }
}
