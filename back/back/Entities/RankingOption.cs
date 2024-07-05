using System.ComponentModel.DataAnnotations;

namespace Entities;

public class RankingOption : Options
{
    [Required]
    public string OptionText { get; set; }
    public int RankValue { get; set; }
}