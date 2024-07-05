using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Vote
    {
        [Key]
        public int VoteId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Poll")]
        public int PollId { get; set; }
        public Poll Poll { get; set; }

        [ForeignKey("Option")]
        public int OptionId { get; set; }
        public Options Option { get; set; }

        public int Points { get; set; }

        public string IpAddress { get; set; }

        public string SessionId { get; set; }

        public string UniqueCode { get; set; }

        public DateTime VotedAt { get; set; }

        public Vote()
        {
            VotedAt = DateTime.UtcNow;
        }
    }
}