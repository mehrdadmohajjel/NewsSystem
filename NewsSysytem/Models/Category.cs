using System;
using System.ComponentModel.DataAnnotations;
namespace NewsSysytem.Models
{
    public class Category
    {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage = "Please enter Title.")]
        public string Title { get; set; }
        public long DisplayOrder { get; set; }
        public DateTime CreationDateTime { get; set; } = DateTime.Now;
    }
}
