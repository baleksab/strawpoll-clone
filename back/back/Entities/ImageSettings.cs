using System.ComponentModel.DataAnnotations;

namespace Entities;

public class ImagesSettings
{
    [Key]
    [ForeignKey("Poll")]
    public int PollId { get; set; }
    public Poll Poll { get; set; }
    
    public bool RequireName { get; set; }
    public bool VotingSecurity { get; set; }
}