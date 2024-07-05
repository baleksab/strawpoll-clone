using System;
using System.ComponentModel.DataAnnotations;

namespace Entities;

public class AdvancedSettings
{
    [Key]
    [ForeignKey("Poll")]
    public int PollId { get; set; }
    public Poll Poll { get; set; }
    
    public DateTime CloseDate { get; set; }
    public bool AllowComments { get; set; }
    public bool HideShareButton { get; set; }
    public ResultVisibility ResultVisibility { get; set; }
    public VotingSecurity VotingSecurity { get; set; }
    public EditVotePermissions EditVotePermissions { get; set; }
}