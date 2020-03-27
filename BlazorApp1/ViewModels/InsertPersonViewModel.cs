using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.ViewModels
{
    public class InsertPersonViewModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "First name is too longs.Should be no more when 15 characters!")]
        [MinLength(3, ErrorMessage = "First name is too short.Should be not less when 3 characters!")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "First name is too longs.Should be no more when 20 characters!")]
        [MinLength(5, ErrorMessage = "First name is too short.Should be not less when 5 characters!")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email address is not in valid format")]
        public string EmailAddress { get; set; }
    }
}
