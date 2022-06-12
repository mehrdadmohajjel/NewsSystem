using System.ComponentModel.DataAnnotations;

namespace NewsSysytem.Models
{
    public class Topic
    {
        [Key]
        public long Id { get; set; }
        public long CaregoryId { get; set; }
        [Required(ErrorMessage = "Please enter Title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter Title.")]
        public string NewsShortBody { get; set; }
        [Required(ErrorMessage = "Please enter Title.")]
        public string NewsFullBody { get; set; }
        public string NewsImage { get; set; }
        public string NewsTag { get; set; }

        public DateTime CreationDateTime { get; set; } = DateTime.Now;

    }
}
