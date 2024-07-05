using System.ComponentModel.DataAnnotations;

namespace Entities;

public class MultipleChoiceOption : Options
{
    [Required]
    public string OptionText { get; set; }
}