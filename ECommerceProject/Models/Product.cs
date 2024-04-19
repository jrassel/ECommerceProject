namespace ECommerceProject.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public int ConfigurationId { get; set; }
        public string ProdCode { get; set; }
        public Boolean IsActive { get; set; }
        public float SalePrice { get; set; }
        public int WarnPoint { get; set; }
        public int Warranty { get; set; }
        public DateTime CreateDate { get; set; }
        public float Vat { get; set; }
        public DateTime UpdateDate { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public string ProductNM { get; set; }
        public Boolean IsDiscount { get; set; }
        public float DiscountAMT { get; set; }
    }
}
