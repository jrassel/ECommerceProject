using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        [Required, StringLength(150)]
        public string Name { get; set; }
        public string Address { get; set; }

    }
}
