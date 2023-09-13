using System.ComponentModel.DataAnnotations;

namespace Cascading.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public  State state { get; set; }
    }
}
