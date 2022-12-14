using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]

        public int id { get; set; } 

        [Required]  
        public string Name { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now; 

    }
}
