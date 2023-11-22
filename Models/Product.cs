using Microsoft.Build.Framework;

namespace FrontToBack_2.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required()]
        public string Name { get; set; }
        public string ImagegUrl { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateTime { get; set; }
        public Departament Department { get; set; } //icindeki departmente kecmek ucun
        public int DepartmentId { get; set; } //one-to-many relations
    }
}
