using System.ComponentModel.DataAnnotations;

namespace CompanySite.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Enter service name")]
        [Display(Name = "Service name")]
        public override string Title { get; set; }

        [Display(Name = "Service short description")]
        public override string Subtitle { get; set; }

        [Display(Name = "Service full description")]
        public override string Text { get; set; }
    }
}
