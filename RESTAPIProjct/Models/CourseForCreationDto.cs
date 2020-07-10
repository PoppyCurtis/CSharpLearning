using RESTAPIProjct.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPIProjct.Models
{
    [CourseTitleMustBeDifferentFromDescription(ErrorMessage = "Title should be different from description")]
    public class CourseForCreationDto //: IValidatableObject
    {
        [Required(ErrorMessage = "You should fill out a title.")]
        [MaxLength(100, ErrorMessage = "The description shouldn't have more than 1500 characters")]
        public string Title { get; set; }
        [MaxLength(1500)]
        public string Description { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Title == Description)
        //    {
        //        yield return new ValidationResult(
        //            "The provided description should be different from the title.",
        //            new[] { "CourseForCreationDto" });
        //    }
        //}
    }
}
