namespace ECommerceProject.Models
{
    public class SalesDetail
    {
        public int Id { get; set; }
        public int SalesOrdId { get; set; }
        public int ProdId { get; set; }
        public string ProdUnit { get; set; }
        public float UnitPrice { get; set; }
        public int SaleQty { get; set; }
    }
}
