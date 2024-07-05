using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities;

public class ImageOption : Options
{
    [Required]
    public string OptionImageUrl { get; set; }
}