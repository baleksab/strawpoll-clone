using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities;

public class Options
{
    [Key]
    public int OptionId { get; set; }

    [ForeignKey("Poll")]
    public int PollId { get; set; }
    public Poll Poll { get; set; }
    
    [Required]
    public OptionType OptionType { get; set; }
}