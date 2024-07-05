using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities;

public class MultipleChoiceSettings
{
    [Key]
    [ForeignKey("Poll")]
    public int PollId { get; set; }
    public Poll Poll { get; set; }

    public bool RequireName { get; set; }

    public bool VotingSecurity { get; set; }
}