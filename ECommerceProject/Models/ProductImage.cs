namespace ECommerceProject.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProdId { get; set; }
        public string ImageName { get; set; }
        public string ImageCode { get; set; }
        public float ImageSize { get; set; }
    }
}
