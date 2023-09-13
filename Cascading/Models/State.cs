using System.ComponentModel.DataAnnotations;

namespace Cascading.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public Country country { get; set; }
    }
}
