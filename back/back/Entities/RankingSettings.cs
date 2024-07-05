using System.ComponentModel.DataAnnotations;

namespace Entities;

public class RankingSettings
{
    [Key]
    [ForeignKey("Poll")]
    public int PollId { get; set; }
    public Poll Poll { get; set; }
    
    public bool RandomOrder { get; set; }
    public int MaxPoints { get; set; }
    public bool RequireName { get; set; }
    public bool VotingSecurity { get; set; }
    public bool BlockVpnUsers { get; set; }
    public bool UseRecaptcha { get; set; }
}