using System;
using System.ComponentModel.DataAnnotations;

namespace StrawpollCloneBackend.Entities
{
    public class Poll
    {
        [Key]
        public class PollId;

        [Required]
        public string Title;

        public DateTime closeDate { get; set; }

        public bool AllowComments { get; set; }

        [Required]
        public PollType PollType { get; set; }
    }
}