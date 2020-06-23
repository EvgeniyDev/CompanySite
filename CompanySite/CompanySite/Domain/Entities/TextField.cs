using System.ComponentModel.DataAnnotations;

namespace CompanySite.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Название страницы")]
        public override string Title { get; set; } = "Информационная страница";

        [Display(Name = "Описание страницы")]
        public override string Text { get; set; } = string.Empty;
    }
}
