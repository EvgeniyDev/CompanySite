using System;
using System.ComponentModel.DataAnnotations;

namespace CompanySite.Domain.Entities
{
    public class EntityBase
    {
        public EntityBase()
        {
            DateAdded = DateTime.UtcNow;
        }

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Title")]
        public virtual string Title { get; set; }

        [Display(Name = "Subtitle")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Full description")]
        public virtual string Text { get; set; }

        [Display(Name = "Title image")]
        public virtual string TitleImage { get; set; }

        [Display(Name = "Title SEO-metatag")]
        public string MetaTitle { get; set; }

        [Display(Name = "Description SEO-metatag")]
        public string MetaDescription { get; set; }

        [Display(Name = "Keywords SEO-metatag")]
        public string MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
