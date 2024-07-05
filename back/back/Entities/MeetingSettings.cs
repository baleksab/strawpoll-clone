using System.ComponentModel.DataAnnotations;

namespace Entities;

public class MeetingSettings
{
    [Key]
    [ForeignKey("Poll")]
    public int PollId { get; set; }
    public Poll Poll { get; set; }
    
    public string FixedTimeZone { get; set; }
    public bool NeedAnswer { get; set; }
    public bool OneOptionOnly { get; set; }
    public bool HideUnavailableOptions { get; set; }
    public string CustomOptionLimits { get; set; }
}