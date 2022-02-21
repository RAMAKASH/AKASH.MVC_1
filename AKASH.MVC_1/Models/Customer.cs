using System.ComponentModel.DataAnnotations;

namespace AKASH.MVC_1.Models
{

    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string mobile { get; set; }
        public Location Location { get; set; }
    }
}
