using System.ComponentModel.DataAnnotations;

namespace Cascading.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
    }
}
