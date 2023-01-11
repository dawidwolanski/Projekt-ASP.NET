using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace bank2.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Pole wymagane")]
        [StringLength(32, ErrorMessage = "{0} musi mieć między {2}, a {1} znaków.", MinimumLength = 6)]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        [StringLength(32, ErrorMessage = "{0} musi mieć między {2}, a {1} znaków.", MinimumLength = 6)]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        [StringLength(32, ErrorMessage = "{0} musi mieć między {2}, a {1} znaków.", MinimumLength = 6)]
        [Display(Name = "Login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        [StringLength(32, ErrorMessage = "{0} musi mieć między {2}, a {1} znaków.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź hasło")]
        [Compare("Password", ErrorMessage = "Hasła nie są identyczne")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        [Display(Name = "Waluta")]
        public int DefaultCurrencyID { get; set; }
    }
}
