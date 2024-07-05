using System.ComponentModel.DataAnnotations;

namespace StrawpollCloneBackend.Entities
{
    public class Options
    {
        [Key]
        public int OptionId { get; set; }

        [ForeignKey("Poll")]
        public int PollId { get; set; }
        public Poll Poll { get; set; }

        [Required]
        public OptionType OptionType { get; set; }
    }
}