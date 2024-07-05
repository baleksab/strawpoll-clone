using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities;

public class MultipleChoiceOption : Options
{
    [Required]
    public string OptionText { get; set; }
}