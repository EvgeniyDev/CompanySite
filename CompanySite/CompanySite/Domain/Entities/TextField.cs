using System.ComponentModel.DataAnnotations;

namespace CompanySite.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Page name")]
        public override string Title { get; set; } = "Informational page";

        [Display(Name = "Page description")]
        public override string Text { get; set; } = string.Empty;
    }
}
