using System.ComponentModel.DataAnnotations;

namespace AKASH.MVC_1.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string Place { get; set; }
        public string Details { get; set; }
    }
}
