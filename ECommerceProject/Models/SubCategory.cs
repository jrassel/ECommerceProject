using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string Name { get; set; }
        public int CategoryID { get; set; }
    }
}
