using System;
using System.ComponentModel.DataAnnotations;

namespace Entities;

public class Poll
{
    [Key]
    public int PollId { get; set; }

    [Required]
    public string Title { get; set; }

    public DateTime CloseDate { get; set; }
    public bool AllowComments { get; set; }
    
    [Required]
    public PollType PollType { get; set; }
}
