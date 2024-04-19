using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
