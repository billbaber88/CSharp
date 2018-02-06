using System.ComponentModel.DataAnnotations;

namespace loginRegistration.Models
{
    public abstract class BaseEntity {}
    public class RegUser : BaseEntity
    {
        [Required(ErrorMessage="Field cannot be left blank")]
        [MinLength(2, ErrorMessage="Name must be at least two letters long")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage="First name can contain letters only")]

        public string name {get; set;}

        [Required(ErrorMessage="Field cannot be left blank")]
        [EmailAddress]
        public string email {get; set;}
        
        [Required(ErrorMessage="Field cannot be left blank")]
        [DataType(DataType.Password)]
        public string password {get; set;}

        [Required(ErrorMessage="Field cannot be left blank")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage="Passwords do not match")]
        public string confirmPassword {get; set;}
    }

    public class LoginUser : BaseEntity
    {
        [Required(ErrorMessage="Field cannot be left blank")]
        [EmailAddress]
        public string email {get; set;}
        
        [Required(ErrorMessage="Field cannot be left blank")]
        [DataType(DataType.Password)]
        public string password {get; set;}
    }

}