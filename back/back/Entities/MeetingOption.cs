using System;
using System.ComponentModel.DataAnnotations;

namespace StrawpollCloneBackend.Entities
{
    public class MeetingOption : Options
    {
        public DateTime MeetingTime { get; set; }
    }
}