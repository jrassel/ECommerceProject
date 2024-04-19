using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
    public class Configuration
    {
        public int Id { get; set; }
        [Required, StringLength(500)]
        public string Name { get; set; }
    }
}
