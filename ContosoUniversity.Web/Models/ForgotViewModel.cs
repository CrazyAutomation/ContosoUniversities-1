using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Web.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}