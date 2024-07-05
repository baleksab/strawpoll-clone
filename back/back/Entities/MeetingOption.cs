using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

public class MeetingOption : Options
{
    public DateTime MeetingTime { get; set; }
}