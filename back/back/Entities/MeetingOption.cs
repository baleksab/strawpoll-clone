using System;
using System.ComponentModel.DataAnnotations;

namespace Entities;

public class MeetingOption : Options
{
    public DateTime MeetingTime { get; set; }
}