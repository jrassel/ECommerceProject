using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
    public class Stock
    {
        public int Id { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime StockDate { get; set; }
        public int ProdId { get; set; }
        public int StockIn { get; set; }
        public int StockOut { get; set; }
        public int StockBalance { get; set; }

    }
}
