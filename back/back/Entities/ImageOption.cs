using System.ComponentModel.DataAnnotations;

namespace StrawpollCloneBackend.Entities
{
    public class ImageOption : Options
    {
        [Required]
        public string OptionImageUrl { get; set; }
    }
}