using System.ComponentModel.DataAnnotations;

namespace User_Management.Models;

public class UserDto
{
    [Required]
    public string firstName { get; set; } = "";

    [Required(ErrorMessage = "Please Provide your Last Name")]
    public string lastName { get; set; } = "";
    [Required, EmailAddress]
    public string email { get; set; } = "";
    public string phone { get; set; } = "";
    [Required]
    [MinLength(5, ErrorMessage = "The Address should be atleast 5 characters")]
    [MaxLength(1000, ErrorMessage = "The Address should be less than 1000 characters")]
    public string address { get; set; } = "";
}
