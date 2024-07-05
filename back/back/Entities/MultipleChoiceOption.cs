using System.ComponentModel.DataAnnotations;

namespace StrawpollCloneBackend.Entities
{
    public class MultipleChoiceOption : Options
    {
        [Required]
        public string OptionText { get; set; }
    }
}