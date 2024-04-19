using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
    public class Model
    {
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string Name { get; set; }
    }
}
