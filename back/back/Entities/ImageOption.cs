using System.ComponentModel.DataAnnotations;

namespace Entities;

public class ImageOption : Options
{
    [Required]
    public string OptionImageUrl { get; set; }
}